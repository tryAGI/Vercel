
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseActiveRulesetsRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseActiveRulesetsRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}