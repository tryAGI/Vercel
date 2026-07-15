
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction
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
    public static class PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Deny => "deny",
                PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Log => "log",
                PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Deny,
                "log" => PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.Log,
                "rate_limit" => PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}