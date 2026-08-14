
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseConditionConditionGroupItemConditionType
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
    public static class GetFirewallConfigResponseConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.BotName => "bot_name",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Cookie => "cookie",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Environment => "environment",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Header => "header",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Host => "host",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Method => "method",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Path => "path",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Protocol => "protocol",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Query => "query",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.RawPath => "raw_path",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Region => "region",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Route => "route",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.Scheme => "scheme",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.ServerAction => "server_action",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.TargetPath => "target_path",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetFirewallConfigResponseConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Header,
                "host" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Host,
                "ip_address" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Method,
                "path" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Path,
                "protocol" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Protocol,
                "query" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.RawPath,
                "region" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Region,
                "route" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Route,
                "ruleset" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.Scheme,
                "server_action" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetFirewallConfigResponseConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}