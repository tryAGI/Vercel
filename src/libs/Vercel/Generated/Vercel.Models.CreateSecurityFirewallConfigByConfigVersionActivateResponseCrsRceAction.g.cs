
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRceAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRceActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRceAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRceAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRceAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRceAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRceAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsRceAction.Log,
                _ => null,
            };
        }
    }
}