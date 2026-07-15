
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}