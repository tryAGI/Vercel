
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}