
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction
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
    public static class PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Deny => "deny",
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Log => "log",
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Deny,
                "log" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Log,
                "rate_limit" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}