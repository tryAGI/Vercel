
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSdAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSdActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSdAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSdAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSdAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSdAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSdAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseCrsSdAction.Log,
                _ => null,
            };
        }
    }
}