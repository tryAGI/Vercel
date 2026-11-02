
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39497871754bda72LastAliasRequestJobStatus
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
    public static class AutoSDKShared39497871754bda72LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39497871754bda72LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared39497871754bda72LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared39497871754bda72LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared39497871754bda72LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared39497871754bda72LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared39497871754bda72LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39497871754bda72LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared39497871754bda72LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared39497871754bda72LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared39497871754bda72LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared39497871754bda72LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared39497871754bda72LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}