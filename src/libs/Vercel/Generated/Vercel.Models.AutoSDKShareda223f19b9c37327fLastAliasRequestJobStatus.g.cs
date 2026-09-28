
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus
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
    public static class AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShareda223f19b9c37327fLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}