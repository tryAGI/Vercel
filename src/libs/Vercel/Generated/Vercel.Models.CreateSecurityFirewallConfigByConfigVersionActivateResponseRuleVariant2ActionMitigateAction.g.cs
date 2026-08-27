
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Bypass,
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
        /// <summary>
        ///
        /// </summary>
        Redirect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Allow => "allow",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Bypass => "bypass",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Log => "log",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.RateLimit => "rate_limit",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Allow,
                "bypass" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Bypass,
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Log,
                "rate_limit" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.RateLimit,
                "redirect" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}