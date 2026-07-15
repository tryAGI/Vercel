
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSfAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSfActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSfAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSfAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSfAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSfAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSfAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSfAction.Log,
                _ => null,
            };
        }
    }
}