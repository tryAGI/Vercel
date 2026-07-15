
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSourcesAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSourcesAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSourcesAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSourcesAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSourcesAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}