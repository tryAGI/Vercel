
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType
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
        SharedCondition,
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
    public static class GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseVersionConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}