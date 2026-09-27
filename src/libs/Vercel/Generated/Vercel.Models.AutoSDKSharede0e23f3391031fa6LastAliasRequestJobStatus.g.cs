
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus
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
    public static class AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharede0e23f3391031fa6LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}