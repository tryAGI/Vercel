
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}