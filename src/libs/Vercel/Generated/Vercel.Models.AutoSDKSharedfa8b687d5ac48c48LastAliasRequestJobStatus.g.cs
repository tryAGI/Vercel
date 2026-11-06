
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus
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
    public static class AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedfa8b687d5ac48c48LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}