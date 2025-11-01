namespace Protocols.LongPolling.Job;

/// <summary>
/// Represents a job.
/// </summary>
public class Job
{
    /// <summary>
    /// Gets or sets the job id.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Gets or sets the job start time.
    /// </summary>
    public DateTimeOffset StartTime { get; set; } = DateTimeOffset.UtcNow;

    /// <summary>
    /// Waits till the job is completed.
    /// </summary>
    public Task WaitTillComplete()
    {
        var finishTime = StartTime + TimeSpan.FromSeconds(10);
        var delay = finishTime - DateTimeOffset.UtcNow;
        return delay > TimeSpan.Zero ? Task.Delay(delay) : Task.CompletedTask;
    }
}
