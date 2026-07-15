
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Allow => "allow",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Bypass => "bypass",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Log => "log",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.RateLimit => "rate_limit",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Allow,
                "bypass" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Bypass,
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Log,
                "rate_limit" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.RateLimit,
                "redirect" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}