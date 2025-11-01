namespace Protocols.Polling.Job;

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
    /// Gets whether the job is completed.
    /// </summary>
    public bool IsCompleted => DateTimeOffset.UtcNow - StartTime > TimeSpan.FromSeconds(10);
}
