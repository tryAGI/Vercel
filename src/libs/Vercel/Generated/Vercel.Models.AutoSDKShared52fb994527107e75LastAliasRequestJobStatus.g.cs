
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared52fb994527107e75LastAliasRequestJobStatus
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
    public static class AutoSDKShared52fb994527107e75LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared52fb994527107e75LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared52fb994527107e75LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared52fb994527107e75LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared52fb994527107e75LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared52fb994527107e75LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared52fb994527107e75LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared52fb994527107e75LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared52fb994527107e75LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared52fb994527107e75LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared52fb994527107e75LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared52fb994527107e75LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared52fb994527107e75LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}