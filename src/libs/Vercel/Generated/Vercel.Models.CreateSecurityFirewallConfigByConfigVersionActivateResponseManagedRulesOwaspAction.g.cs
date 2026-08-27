
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwaspAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwaspAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwaspAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwaspAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwaspAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwaspAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}