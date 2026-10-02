
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus
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
    public static class AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedfe1f84289679c6c4LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}