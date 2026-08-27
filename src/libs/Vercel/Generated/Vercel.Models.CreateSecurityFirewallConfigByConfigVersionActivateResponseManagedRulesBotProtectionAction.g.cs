
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtectionAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtectionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtectionAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtectionAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtectionAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtectionAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtectionAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtectionAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtectionAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtectionAction.Log,
                _ => null,
            };
        }
    }
}