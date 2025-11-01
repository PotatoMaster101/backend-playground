using Protocols.Polling.Job;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapPost("/job", () => Results.Ok(JobStore.CreateJob()));
app.MapGet("/job", (Guid id) => Results.Ok(JobStore.GetJobCompleted(id)));
app.Run();
