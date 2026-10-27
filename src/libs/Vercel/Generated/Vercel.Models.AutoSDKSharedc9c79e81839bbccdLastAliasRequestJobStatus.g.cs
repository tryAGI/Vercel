
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus
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
    public static class AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedc9c79e81839bbccdLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}