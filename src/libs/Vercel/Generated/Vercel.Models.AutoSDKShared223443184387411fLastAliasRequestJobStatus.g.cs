
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared223443184387411fLastAliasRequestJobStatus
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
    public static class AutoSDKShared223443184387411fLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared223443184387411fLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared223443184387411fLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared223443184387411fLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared223443184387411fLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared223443184387411fLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared223443184387411fLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared223443184387411fLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared223443184387411fLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared223443184387411fLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared223443184387411fLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared223443184387411fLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared223443184387411fLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}