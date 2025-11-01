using Protocols.LongPolling.Job;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapPost("/job", () => Results.Ok(JobStore.CreateJob()));
app.MapGet("/job", async (Guid id) =>
{
    if (JobStore.GetJob(id) is not { } job)
        return Results.NotFound();

    await job.WaitTillComplete();
    return Results.Ok();
});
app.Run();
