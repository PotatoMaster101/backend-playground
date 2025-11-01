namespace Protocols.Polling.Job;

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
    /// Returns whether a job is completed.
    /// </summary>
    public static bool GetJobCompleted(Guid id)
    {
        return Jobs.TryGetValue(id, out var job) && job.IsCompleted;
    }
}
