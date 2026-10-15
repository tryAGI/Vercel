
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction
    {
        /// <summary>
        ///
        /// </summary>
        Challenge,
        /// <summary>
        ///
        /// </summary>
        Deny,
        /// <summary>
        ///
        /// </summary>
        Log,
        /// <summary>
        ///
        /// </summary>
        RateLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction value)
        {
            return value switch
            {
                AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction.Challenge => "challenge",
                AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction.Deny => "deny",
                AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction.Log => "log",
                AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction.Challenge,
                "deny" => AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction.Deny,
                "log" => AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction.Log,
                "rate_limit" => AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}