
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus
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
    public static class AutoSDKSharede052f139ff613de3LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharede052f139ff613de3LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}