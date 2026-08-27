
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsPhpAction
    {
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsPhpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsPhpAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsPhpAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsPhpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsPhpAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsPhpAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsPhpAction.Log,
                _ => null,
            };
        }
    }
}