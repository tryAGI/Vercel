
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus
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
    public static class AutoSDKShared7851faacb4798d73LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared7851faacb4798d73LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}