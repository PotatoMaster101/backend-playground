namespace Protocols.LongPolling.Job;

/// <summary>
/// Storage for current running jobs.
/// </summary>
public static class JobStore
{
    private static readonly Dictionary<Guid, Job> Jobs = new();

    /// <summary>
    /// Creates a new job and return the job ID.
    /// </summary>
    public static Guid CreateJob()
    {
        var job = new Job();
        Jobs.Add(job.Id, job);
        return job.Id;
    }

    /// <summary>
    /// Returns a specific job.
    /// </summary>
    public static Job? GetJob(Guid id)
    {
        return Jobs.GetValueOrDefault(id);
    }
}
