
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus
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
    public static class AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharede27e7ff1aa86f19eLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}