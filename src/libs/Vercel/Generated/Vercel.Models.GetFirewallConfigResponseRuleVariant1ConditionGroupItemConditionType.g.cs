
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType
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
    public static class GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.BotCategory => "bot_category",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.BotName => "bot_name",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Cookie => "cookie",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Environment => "environment",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.GeoCity => "geo_city",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Header => "header",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Host => "host",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.IpAddress => "ip_address",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Method => "method",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Path => "path",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Protocol => "protocol",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Query => "query",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.RawPath => "raw_path",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Region => "region",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Route => "route",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Scheme => "scheme",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.ServerAction => "server_action",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.TargetPath => "target_path",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.BotName,
                "cookie" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Cookie,
                "environment" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Header,
                "host" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Host,
                "ip_address" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Ja4Digest,
                "method" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Method,
                "path" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Path,
                "protocol" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Protocol,
                "query" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.RawPath,
                "region" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Region,
                "route" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Route,
                "scheme" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.Scheme,
                "server_action" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.ServerAction,
                "target_path" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.TargetPath,
                "user_agent" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}