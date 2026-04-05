
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus
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
    public static class GetProjectsResponseVariant3ProjectLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus.Failed => "failed",
                GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus.InProgress => "in-progress",
                GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus.Pending => "pending",
                GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus.Skipped => "skipped",
                GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus.Failed,
                "in-progress" => GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus.InProgress,
                "pending" => GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus.Pending,
                "skipped" => GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus.Skipped,
                "succeeded" => GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}