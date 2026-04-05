
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType
    {
        /// <summary>
        /// 
        /// </summary>
        Cookie,
        /// <summary>
        /// 
        /// </summary>
        Environment,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Host,
        /// <summary>
        /// 
        /// </summary>
        InitialRequestPath,
        /// <summary>
        /// 
        /// </summary>
        IpAddress,
        /// <summary>
        /// 
        /// </summary>
        Method,
        /// <summary>
        /// 
        /// </summary>
        Path,
        /// <summary>
        /// 
        /// </summary>
        Protocol,
        /// <summary>
        /// 
        /// </summary>
        Query,
        /// <summary>
        /// 
        /// </summary>
        Region,
        /// <summary>
        /// 
        /// </summary>
        Scheme,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Cookie => "cookie",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Environment => "environment",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Header => "header",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Host => "host",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.InitialRequestPath => "initial_request_path",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.IpAddress => "ip_address",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Method => "method",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Path => "path",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Protocol => "protocol",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Query => "query",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Region => "region",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Scheme => "scheme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Cookie,
                "environment" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Environment,
                "header" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Header,
                "host" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Host,
                "initial_request_path" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.InitialRequestPath,
                "ip_address" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.IpAddress,
                "method" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Method,
                "path" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Path,
                "protocol" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Protocol,
                "query" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Query,
                "region" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Region,
                "scheme" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType.Scheme,
                _ => null,
            };
        }
    }
}