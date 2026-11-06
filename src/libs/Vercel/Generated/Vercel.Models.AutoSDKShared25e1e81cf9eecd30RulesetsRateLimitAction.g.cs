
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction
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
    public static class AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction value)
        {
            return value switch
            {
                AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction.Challenge => "challenge",
                AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction.Deny => "deny",
                AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction.Log => "log",
                AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction.Challenge,
                "deny" => AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction.Deny,
                "log" => AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction.Log,
                "rate_limit" => AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}