
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus
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
    public static class AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}