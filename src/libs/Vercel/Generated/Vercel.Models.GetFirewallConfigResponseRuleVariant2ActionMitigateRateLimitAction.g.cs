
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction
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
    public static class GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction.Challenge => "challenge",
                GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction.Deny => "deny",
                GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction.Log => "log",
                GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction.Challenge,
                "deny" => GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction.Deny,
                "log" => GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction.Log,
                "rate_limit" => GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}