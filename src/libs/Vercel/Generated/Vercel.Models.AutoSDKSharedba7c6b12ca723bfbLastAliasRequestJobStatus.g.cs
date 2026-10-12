
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus
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
    public static class AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedba7c6b12ca723bfbLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}