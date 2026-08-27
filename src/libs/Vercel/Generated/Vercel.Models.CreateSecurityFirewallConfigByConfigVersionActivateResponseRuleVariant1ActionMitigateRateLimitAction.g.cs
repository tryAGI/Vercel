
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction.Log => "log",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction.Log,
                "rate_limit" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}