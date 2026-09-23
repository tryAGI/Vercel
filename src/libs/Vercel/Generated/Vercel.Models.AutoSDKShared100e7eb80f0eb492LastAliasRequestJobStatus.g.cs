
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus
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
    public static class AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared100e7eb80f0eb492LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}