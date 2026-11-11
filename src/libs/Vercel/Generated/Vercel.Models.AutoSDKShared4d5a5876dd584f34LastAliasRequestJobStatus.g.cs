
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus
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
    public static class AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared4d5a5876dd584f34LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}