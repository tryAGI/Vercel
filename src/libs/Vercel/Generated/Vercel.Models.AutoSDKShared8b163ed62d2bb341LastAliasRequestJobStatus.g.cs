
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus
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
    public static class AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared8b163ed62d2bb341LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}