
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType
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
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotCategory => "bot_category",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotName => "bot_name",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotProtection => "bot_protection",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotStatus => "bot_status",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Cookie => "cookie",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Environment => "environment",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCity => "geo_city",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCountry => "geo_country",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Header => "header",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Host => "host",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.IpAddress => "ip_address",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Method => "method",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Path => "path",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Protocol => "protocol",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Query => "query",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.RawPath => "raw_path",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Region => "region",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Route => "route",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Scheme => "scheme",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.ServerAction => "server_action",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.TargetPath => "target_path",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotCategory,
                "bot_name" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotName,
                "bot_protection" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotProtection,
                "bot_status" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotStatus,
                "cookie" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Cookie,
                "environment" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Environment,
                "geo_as_number" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Header,
                "host" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Host,
                "ip_address" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Ja4Digest,
                "method" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Method,
                "path" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Path,
                "protocol" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Protocol,
                "query" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.RawPath,
                "region" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Region,
                "route" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Route,
                "scheme" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Scheme,
                "server_action" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.ServerAction,
                "target_path" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.TargetPath,
                "user_agent" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}