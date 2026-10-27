
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus
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
    public static class AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedbe3f0c688bc34a31LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}