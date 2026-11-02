
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus
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
    public static class AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedf5934c240f4382f7LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}