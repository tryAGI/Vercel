
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}