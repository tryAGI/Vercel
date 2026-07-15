
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}