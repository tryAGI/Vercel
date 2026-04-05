
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseLastAliasRequestJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLastAliasRequestJobStatus value)
        {
            return value switch
            {
                UpdateProjectResponseLastAliasRequestJobStatus.Failed => "failed",
                UpdateProjectResponseLastAliasRequestJobStatus.InProgress => "in-progress",
                UpdateProjectResponseLastAliasRequestJobStatus.Pending => "pending",
                UpdateProjectResponseLastAliasRequestJobStatus.Skipped => "skipped",
                UpdateProjectResponseLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => UpdateProjectResponseLastAliasRequestJobStatus.Failed,
                "in-progress" => UpdateProjectResponseLastAliasRequestJobStatus.InProgress,
                "pending" => UpdateProjectResponseLastAliasRequestJobStatus.Pending,
                "skipped" => UpdateProjectResponseLastAliasRequestJobStatus.Skipped,
                "succeeded" => UpdateProjectResponseLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}