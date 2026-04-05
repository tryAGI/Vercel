
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateLogHeaders value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}