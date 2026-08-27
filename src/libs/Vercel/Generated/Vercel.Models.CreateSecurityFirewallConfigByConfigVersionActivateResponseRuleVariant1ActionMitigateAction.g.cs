
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Allow => "allow",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Bypass => "bypass",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Log => "log",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.RateLimit => "rate_limit",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Allow,
                "bypass" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Bypass,
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Log,
                "rate_limit" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.RateLimit,
                "redirect" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}