
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus
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
    public static class AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedea12f8422dc06e51LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}