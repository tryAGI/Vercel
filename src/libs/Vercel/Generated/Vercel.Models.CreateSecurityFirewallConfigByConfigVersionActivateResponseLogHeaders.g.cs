
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseLogHeaders value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => CreateSecurityFirewallConfigByConfigVersionActivateResponseLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}