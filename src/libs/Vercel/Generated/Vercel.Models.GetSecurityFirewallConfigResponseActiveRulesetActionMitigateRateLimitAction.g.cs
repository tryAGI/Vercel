
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}