
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType
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
    public static class GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.BotCategory => "bot_category",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.BotName => "bot_name",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Cookie => "cookie",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Environment => "environment",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.GeoCity => "geo_city",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Header => "header",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Host => "host",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.IpAddress => "ip_address",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Method => "method",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Path => "path",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Protocol => "protocol",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Query => "query",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.RawPath => "raw_path",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Region => "region",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Route => "route",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Scheme => "scheme",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.ServerAction => "server_action",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.TargetPath => "target_path",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.BotName,
                "cookie" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Cookie,
                "environment" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Header,
                "host" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Host,
                "ip_address" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Ja4Digest,
                "method" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Method,
                "path" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Path,
                "protocol" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Protocol,
                "query" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.RawPath,
                "region" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Region,
                "route" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Route,
                "scheme" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.Scheme,
                "server_action" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.ServerAction,
                "target_path" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.TargetPath,
                "user_agent" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}