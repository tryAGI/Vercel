
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseIpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction.Bypass => "bypass",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction.Bypass,
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseIpAction.Log,
                _ => null,
            };
        }
    }
}