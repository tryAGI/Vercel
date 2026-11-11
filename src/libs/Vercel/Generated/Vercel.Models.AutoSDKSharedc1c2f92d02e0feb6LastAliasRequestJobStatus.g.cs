
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus
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
    public static class AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}