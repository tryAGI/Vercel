
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType
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
    public static class PutFirewallConfigResponseActiveConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotName => "bot_name",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Cookie => "cookie",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Environment => "environment",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Header => "header",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Host => "host",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Method => "method",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Path => "path",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Protocol => "protocol",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Query => "query",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.RawPath => "raw_path",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Region => "region",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Route => "route",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Scheme => "scheme",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.ServerAction => "server_action",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.TargetPath => "target_path",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Header,
                "host" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Host,
                "ip_address" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Method,
                "path" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Path,
                "protocol" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Protocol,
                "query" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.RawPath,
                "region" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Region,
                "route" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Route,
                "ruleset" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.Scheme,
                "server_action" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.ServerAction,
                "target_path" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.TargetPath,
                "trusted_source" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}