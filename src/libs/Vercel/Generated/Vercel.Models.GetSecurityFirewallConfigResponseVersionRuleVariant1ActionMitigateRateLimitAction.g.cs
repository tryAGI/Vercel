
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}