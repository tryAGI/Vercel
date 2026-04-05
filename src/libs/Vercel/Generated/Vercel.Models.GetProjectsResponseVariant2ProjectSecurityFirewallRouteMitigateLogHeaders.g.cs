
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateLogHeaders value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}