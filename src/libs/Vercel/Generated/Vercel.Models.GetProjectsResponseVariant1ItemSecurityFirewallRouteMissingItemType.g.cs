
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType
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
    public static class GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Cookie => "cookie",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Environment => "environment",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Header => "header",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Host => "host",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.InitialRequestPath => "initial_request_path",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.IpAddress => "ip_address",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Method => "method",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Path => "path",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Protocol => "protocol",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Query => "query",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Region => "region",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Scheme => "scheme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Cookie,
                "environment" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Environment,
                "header" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Header,
                "host" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Host,
                "initial_request_path" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.InitialRequestPath,
                "ip_address" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.IpAddress,
                "method" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Method,
                "path" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Path,
                "protocol" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Protocol,
                "query" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Query,
                "region" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Region,
                "scheme" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType.Scheme,
                _ => null,
            };
        }
    }
}