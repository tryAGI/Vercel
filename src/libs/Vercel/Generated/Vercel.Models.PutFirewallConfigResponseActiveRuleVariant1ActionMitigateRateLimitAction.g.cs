
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction
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
    public static class PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Deny => "deny",
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Log => "log",
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Deny,
                "log" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Log,
                "rate_limit" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}