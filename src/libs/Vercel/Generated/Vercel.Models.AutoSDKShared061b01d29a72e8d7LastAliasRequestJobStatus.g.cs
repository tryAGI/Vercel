
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus
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
    public static class AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared061b01d29a72e8d7LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}