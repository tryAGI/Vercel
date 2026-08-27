
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateLogHeaders value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}