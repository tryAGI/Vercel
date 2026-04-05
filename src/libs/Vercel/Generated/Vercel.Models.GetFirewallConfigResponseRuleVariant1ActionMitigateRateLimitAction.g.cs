
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction
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
    public static class GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction.Challenge => "challenge",
                GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction.Deny => "deny",
                GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction.Log => "log",
                GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction.Challenge,
                "deny" => GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction.Deny,
                "log" => GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction.Log,
                "rate_limit" => GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}