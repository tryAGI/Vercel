
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        BotCategory,
        /// <summary>
        /// 
        /// </summary>
        BotName,
        /// <summary>
        /// 
        /// </summary>
        BotProtection,
        /// <summary>
        /// 
        /// </summary>
        BotStatus,
        /// <summary>
        /// 
        /// </summary>
        Cookie,
        /// <summary>
        /// 
        /// </summary>
        DomainEnvironment,
        /// <summary>
        /// 
        /// </summary>
        Environment,
        /// <summary>
        /// 
        /// </summary>
        GeoAsNumber,
        /// <summary>
        /// 
        /// </summary>
        GeoCity,
        /// <summary>
        /// 
        /// </summary>
        GeoContinent,
        /// <summary>
        /// 
        /// </summary>
        GeoCountry,
        /// <summary>
        /// 
        /// </summary>
        GeoCountryRegion,
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
        IpAddress,
        /// <summary>
        /// 
        /// </summary>
        Ja3Digest,
        /// <summary>
        /// 
        /// </summary>
        Ja4Digest,
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
        RateLimitApiId,
        /// <summary>
        /// 
        /// </summary>
        RawPath,
        /// <summary>
        /// 
        /// </summary>
        Region,
        /// <summary>
        /// 
        /// </summary>
        Route,
        /// <summary>
        /// 
        /// </summary>
        Ruleset,
        /// <summary>
        /// 
        /// </summary>
        Scheme,
        /// <summary>
        /// 
        /// </summary>
        ServerAction,
        /// <summary>
        /// 
        /// </summary>
        TargetPath,
        /// <summary>
        /// 
        /// </summary>
        TrustedSource,
        /// <summary>
        /// 
        /// </summary>
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.ServerAction,
                "target_path" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}