
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsGenAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsGenActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsGenAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsGenAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsGenAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsGenAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsGenAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsGenAction.Log,
                _ => null,
            };
        }
    }
}