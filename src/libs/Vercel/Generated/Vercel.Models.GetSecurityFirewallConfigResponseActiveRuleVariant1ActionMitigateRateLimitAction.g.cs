
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}