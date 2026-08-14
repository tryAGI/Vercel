
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType
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
    public static class GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.ServerAction,
                "target_path" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseDraftConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}