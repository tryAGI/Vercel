
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}