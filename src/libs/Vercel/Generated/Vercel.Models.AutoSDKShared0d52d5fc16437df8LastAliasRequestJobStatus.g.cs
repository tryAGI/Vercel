
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus
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
    public static class AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared0d52d5fc16437df8LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}