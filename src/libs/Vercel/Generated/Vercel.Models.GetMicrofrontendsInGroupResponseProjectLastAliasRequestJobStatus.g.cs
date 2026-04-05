
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus
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
    public static class GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus.Failed => "failed",
                GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus.InProgress => "in-progress",
                GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus.Pending => "pending",
                GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus.Skipped => "skipped",
                GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus.Failed,
                "in-progress" => GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus.InProgress,
                "pending" => GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus.Pending,
                "skipped" => GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus.Skipped,
                "succeeded" => GetMicrofrontendsInGroupResponseProjectLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}