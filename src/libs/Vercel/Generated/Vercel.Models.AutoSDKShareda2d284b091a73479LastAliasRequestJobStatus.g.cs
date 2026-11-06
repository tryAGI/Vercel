
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus
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
    public static class AutoSDKShareda2d284b091a73479LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShareda2d284b091a73479LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}