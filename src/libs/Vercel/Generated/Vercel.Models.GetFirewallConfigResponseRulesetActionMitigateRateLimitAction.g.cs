
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetFirewallConfigResponseRulesetActionMitigateRateLimitAction
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
    public static class GetFirewallConfigResponseRulesetActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRulesetActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseRulesetActionMitigateRateLimitAction.Challenge => "challenge",
                GetFirewallConfigResponseRulesetActionMitigateRateLimitAction.Deny => "deny",
                GetFirewallConfigResponseRulesetActionMitigateRateLimitAction.Log => "log",
                GetFirewallConfigResponseRulesetActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRulesetActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetFirewallConfigResponseRulesetActionMitigateRateLimitAction.Challenge,
                "deny" => GetFirewallConfigResponseRulesetActionMitigateRateLimitAction.Deny,
                "log" => GetFirewallConfigResponseRulesetActionMitigateRateLimitAction.Log,
                "rate_limit" => GetFirewallConfigResponseRulesetActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}