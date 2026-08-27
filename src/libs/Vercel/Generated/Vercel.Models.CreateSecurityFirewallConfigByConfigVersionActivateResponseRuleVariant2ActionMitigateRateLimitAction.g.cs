
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction.Log => "log",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction.Log,
                "rate_limit" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}