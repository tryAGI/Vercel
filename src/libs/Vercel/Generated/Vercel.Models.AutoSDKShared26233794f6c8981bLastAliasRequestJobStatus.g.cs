
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus
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
    public static class AutoSDKShared26233794f6c8981bLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared26233794f6c8981bLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}