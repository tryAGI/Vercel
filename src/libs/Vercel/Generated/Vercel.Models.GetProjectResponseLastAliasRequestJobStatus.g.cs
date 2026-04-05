
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseLastAliasRequestJobStatus
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
    public static class GetProjectResponseLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLastAliasRequestJobStatus value)
        {
            return value switch
            {
                GetProjectResponseLastAliasRequestJobStatus.Failed => "failed",
                GetProjectResponseLastAliasRequestJobStatus.InProgress => "in-progress",
                GetProjectResponseLastAliasRequestJobStatus.Pending => "pending",
                GetProjectResponseLastAliasRequestJobStatus.Skipped => "skipped",
                GetProjectResponseLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => GetProjectResponseLastAliasRequestJobStatus.Failed,
                "in-progress" => GetProjectResponseLastAliasRequestJobStatus.InProgress,
                "pending" => GetProjectResponseLastAliasRequestJobStatus.Pending,
                "skipped" => GetProjectResponseLastAliasRequestJobStatus.Skipped,
                "succeeded" => GetProjectResponseLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}