
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus
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
    public static class AutoSDKShared429ed81b15078f20LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared429ed81b15078f20LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}