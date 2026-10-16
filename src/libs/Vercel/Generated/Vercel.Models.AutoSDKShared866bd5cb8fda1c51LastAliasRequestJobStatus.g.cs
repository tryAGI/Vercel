
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus
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
    public static class AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared866bd5cb8fda1c51LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}