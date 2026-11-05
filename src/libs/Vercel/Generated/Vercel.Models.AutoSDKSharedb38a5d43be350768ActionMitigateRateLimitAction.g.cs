
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction
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
    public static class AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction.Challenge => "challenge",
                AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction.Deny => "deny",
                AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction.Log => "log",
                AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction.Challenge,
                "deny" => AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction.Deny,
                "log" => AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction.Log,
                "rate_limit" => AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}