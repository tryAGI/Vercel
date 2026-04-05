
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandle
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
    public static class GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandle value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandle.Finalize => "finalize",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandle.Init => "init",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandle? ToEnum(string value)
        {
            return value switch
            {
                "finalize" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandle.Finalize,
                "init" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandle.Init,
                _ => null,
            };
        }
    }
}