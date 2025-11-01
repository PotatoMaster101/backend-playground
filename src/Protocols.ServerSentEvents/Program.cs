var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/sse", async context =>
{
    context.Response.Headers.Append("Content-Type", "text/event-stream");
    var session = Guid.NewGuid().ToString();
    for (var i = 0; i < 10000; i++)
    {
        // events must be sent in format "data: ...\n\n"
        await context.Response.WriteAsync($"data: Event for {session}, number: {i}\n\n");
        await context.Response.Body.FlushAsync();
        await Task.Delay(1000);
    }
});
app.Run();
