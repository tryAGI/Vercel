
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseVersionRulesetsRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseVersionRulesetsRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}