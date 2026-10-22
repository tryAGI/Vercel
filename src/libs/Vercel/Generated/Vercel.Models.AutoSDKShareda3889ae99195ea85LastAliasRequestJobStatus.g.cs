
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus
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
    public static class AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShareda3889ae99195ea85LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}