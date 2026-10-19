
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus
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
    public static class AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared94b26a5607c7a373LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}