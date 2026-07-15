
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}