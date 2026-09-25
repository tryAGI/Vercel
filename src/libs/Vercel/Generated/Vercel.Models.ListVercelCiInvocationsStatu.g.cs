
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListVercelCiInvocationsStatu
    {
        /// <summary>
        ///
        /// </summary>
        AwaitingJobs,
        /// <summary>
        ///
        /// </summary>
        Bootstrapping,
        /// <summary>
        ///
        /// </summary>
        BootstrappingFailed,
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        JobsOnHiveCloneDispatched,
        /// <summary>
        ///
        /// </summary>
        JobsOnHiveCompleted,
        /// <summary>
        ///
        /// </summary>
        JobsOnHiveDispatched,
        /// <summary>
        ///
        /// </summary>
        JobsOnHiveFailed,
        /// <summary>
        ///
        /// </summary>
        New,
        /// <summary>
        ///
        /// </summary>
        SandboxNamed,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Snapshotted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVercelCiInvocationsStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVercelCiInvocationsStatu value)
        {
            return value switch
            {
                ListVercelCiInvocationsStatu.AwaitingJobs => "awaiting_jobs",
                ListVercelCiInvocationsStatu.Bootstrapping => "bootstrapping",
                ListVercelCiInvocationsStatu.BootstrappingFailed => "bootstrapping_failed",
                ListVercelCiInvocationsStatu.Completed => "completed",
                ListVercelCiInvocationsStatu.JobsOnHiveCloneDispatched => "jobs_on_hive_clone_dispatched",
                ListVercelCiInvocationsStatu.JobsOnHiveCompleted => "jobs_on_hive_completed",
                ListVercelCiInvocationsStatu.JobsOnHiveDispatched => "jobs_on_hive_dispatched",
                ListVercelCiInvocationsStatu.JobsOnHiveFailed => "jobs_on_hive_failed",
                ListVercelCiInvocationsStatu.New => "new",
                ListVercelCiInvocationsStatu.SandboxNamed => "sandbox_named",
                ListVercelCiInvocationsStatu.Skipped => "skipped",
                ListVercelCiInvocationsStatu.Snapshotted => "snapshotted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVercelCiInvocationsStatu? ToEnum(string value)
        {
            return value switch
            {
                "awaiting_jobs" => ListVercelCiInvocationsStatu.AwaitingJobs,
                "bootstrapping" => ListVercelCiInvocationsStatu.Bootstrapping,
                "bootstrapping_failed" => ListVercelCiInvocationsStatu.BootstrappingFailed,
                "completed" => ListVercelCiInvocationsStatu.Completed,
                "jobs_on_hive_clone_dispatched" => ListVercelCiInvocationsStatu.JobsOnHiveCloneDispatched,
                "jobs_on_hive_completed" => ListVercelCiInvocationsStatu.JobsOnHiveCompleted,
                "jobs_on_hive_dispatched" => ListVercelCiInvocationsStatu.JobsOnHiveDispatched,
                "jobs_on_hive_failed" => ListVercelCiInvocationsStatu.JobsOnHiveFailed,
                "new" => ListVercelCiInvocationsStatu.New,
                "sandbox_named" => ListVercelCiInvocationsStatu.SandboxNamed,
                "skipped" => ListVercelCiInvocationsStatu.Skipped,
                "snapshotted" => ListVercelCiInvocationsStatu.Snapshotted,
                _ => null,
            };
        }
    }
}