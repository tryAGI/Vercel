
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRulesetAction
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRulesetAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRulesetAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRulesetAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRulesetAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}