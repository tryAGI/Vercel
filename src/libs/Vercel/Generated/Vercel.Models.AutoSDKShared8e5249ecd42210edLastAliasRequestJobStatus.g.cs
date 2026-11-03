
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus
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
    public static class AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared8e5249ecd42210edLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}