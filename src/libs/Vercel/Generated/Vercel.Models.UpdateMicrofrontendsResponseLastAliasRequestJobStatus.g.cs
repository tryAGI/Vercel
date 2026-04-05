
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseLastAliasRequestJobStatus
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
    public static class UpdateMicrofrontendsResponseLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseLastAliasRequestJobStatus value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseLastAliasRequestJobStatus.Failed => "failed",
                UpdateMicrofrontendsResponseLastAliasRequestJobStatus.InProgress => "in-progress",
                UpdateMicrofrontendsResponseLastAliasRequestJobStatus.Pending => "pending",
                UpdateMicrofrontendsResponseLastAliasRequestJobStatus.Skipped => "skipped",
                UpdateMicrofrontendsResponseLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => UpdateMicrofrontendsResponseLastAliasRequestJobStatus.Failed,
                "in-progress" => UpdateMicrofrontendsResponseLastAliasRequestJobStatus.InProgress,
                "pending" => UpdateMicrofrontendsResponseLastAliasRequestJobStatus.Pending,
                "skipped" => UpdateMicrofrontendsResponseLastAliasRequestJobStatus.Skipped,
                "succeeded" => UpdateMicrofrontendsResponseLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}