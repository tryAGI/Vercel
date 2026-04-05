
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType
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
    public static class GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Cookie => "cookie",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Environment => "environment",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Header => "header",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Host => "host",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.InitialRequestPath => "initial_request_path",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.IpAddress => "ip_address",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Method => "method",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Path => "path",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Protocol => "protocol",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Query => "query",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Region => "region",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Scheme => "scheme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Cookie,
                "environment" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Environment,
                "header" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Header,
                "host" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Host,
                "initial_request_path" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.InitialRequestPath,
                "ip_address" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.IpAddress,
                "method" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Method,
                "path" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Path,
                "protocol" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Protocol,
                "query" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Query,
                "region" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Region,
                "scheme" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItemType.Scheme,
                _ => null,
            };
        }
    }
}