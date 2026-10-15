
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction
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
    public static class AutoSDKSharedc60721415ef8a2a0Variant2RateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction value)
        {
            return value switch
            {
                AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction.Challenge => "challenge",
                AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction.Deny => "deny",
                AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction.Log => "log",
                AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction.Challenge,
                "deny" => AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction.Deny,
                "log" => AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction.Log,
                "rate_limit" => AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}