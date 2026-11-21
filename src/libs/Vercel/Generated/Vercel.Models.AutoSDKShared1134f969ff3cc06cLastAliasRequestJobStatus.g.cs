
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus
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
    public static class AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared1134f969ff3cc06cLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}