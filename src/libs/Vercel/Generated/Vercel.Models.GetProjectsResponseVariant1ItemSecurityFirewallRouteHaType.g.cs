
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType
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
    public static class GetProjectsResponseVariant1ItemSecurityFirewallRouteHaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Cookie => "cookie",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Environment => "environment",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Header => "header",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Host => "host",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.InitialRequestPath => "initial_request_path",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.IpAddress => "ip_address",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Method => "method",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Path => "path",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Protocol => "protocol",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Query => "query",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Region => "region",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Scheme => "scheme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Cookie,
                "environment" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Environment,
                "header" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Header,
                "host" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Host,
                "initial_request_path" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.InitialRequestPath,
                "ip_address" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.IpAddress,
                "method" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Method,
                "path" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Path,
                "protocol" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Protocol,
                "query" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Query,
                "region" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Region,
                "scheme" => GetProjectsResponseVariant1ItemSecurityFirewallRouteHaType.Scheme,
                _ => null,
            };
        }
    }
}