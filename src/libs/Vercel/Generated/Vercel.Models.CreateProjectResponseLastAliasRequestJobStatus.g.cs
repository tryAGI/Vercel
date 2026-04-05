
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseLastAliasRequestJobStatus
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
    public static class CreateProjectResponseLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLastAliasRequestJobStatus value)
        {
            return value switch
            {
                CreateProjectResponseLastAliasRequestJobStatus.Failed => "failed",
                CreateProjectResponseLastAliasRequestJobStatus.InProgress => "in-progress",
                CreateProjectResponseLastAliasRequestJobStatus.Pending => "pending",
                CreateProjectResponseLastAliasRequestJobStatus.Skipped => "skipped",
                CreateProjectResponseLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => CreateProjectResponseLastAliasRequestJobStatus.Failed,
                "in-progress" => CreateProjectResponseLastAliasRequestJobStatus.InProgress,
                "pending" => CreateProjectResponseLastAliasRequestJobStatus.Pending,
                "skipped" => CreateProjectResponseLastAliasRequestJobStatus.Skipped,
                "succeeded" => CreateProjectResponseLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}