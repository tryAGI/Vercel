
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus
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
    public static class AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared2eb5520e92a3b839LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}