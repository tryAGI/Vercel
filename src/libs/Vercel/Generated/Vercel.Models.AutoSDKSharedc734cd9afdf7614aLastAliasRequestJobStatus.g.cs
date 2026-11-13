
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus
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
    public static class AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedc734cd9afdf7614aLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}