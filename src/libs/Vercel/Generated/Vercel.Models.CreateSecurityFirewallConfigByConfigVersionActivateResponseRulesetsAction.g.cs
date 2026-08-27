
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Allow => "allow",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Bypass => "bypass",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Log => "log",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.RateLimit => "rate_limit",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Allow,
                "bypass" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Bypass,
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Log,
                "rate_limit" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.RateLimit,
                "redirect" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}