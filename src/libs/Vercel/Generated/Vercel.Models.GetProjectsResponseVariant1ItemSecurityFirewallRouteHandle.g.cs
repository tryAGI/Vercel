
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityFirewallRouteHandle
    {
        /// <summary>
        /// 
        /// </summary>
        Finalize,
        /// <summary>
        /// 
        /// </summary>
        Init,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemSecurityFirewallRouteHandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityFirewallRouteHandle value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHandle.Finalize => "finalize",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHandle.Init => "init",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityFirewallRouteHandle? ToEnum(string value)
        {
            return value switch
            {
                "finalize" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHandle.Finalize,
                "init" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHandle.Init,
                _ => null,
            };
        }
    }
}