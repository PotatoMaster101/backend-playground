using System.Text;
using Protocols.PublishSubscribe;
using Protocols.PublishSubscribe.Requests;
using RabbitMQ.Client;

const string queueName = "jobs";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapPost("/publish", async (PublishRequest request) =>
{
    await using var connection = await RabbitMqFactory.GetConnection();
    await using var channel = await connection.CreateChannelAsync();
    await channel.QueueDeclareAsync(queueName, false, false, false);
    await channel.BasicPublishAsync("", queueName, false, new BasicProperties(), request.Encode());
    return Results.Ok();
});
app.MapGet("/consume", async () =>
{
    await using var connection = await RabbitMqFactory.GetConnection();
    await using var channel = await connection.CreateChannelAsync();
    await channel.QueueDeclareAsync(queueName, false, false, false);
    var results = new List<string>();
    while (await channel.BasicGetAsync(queueName, true) is { } result)
        results.Add(Encoding.UTF8.GetString(result.Body.Span));

    return Results.Ok(results);
});
app.Run();
