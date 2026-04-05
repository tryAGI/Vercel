
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType
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
    public static class PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotCategory => "bot_category",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotName => "bot_name",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Cookie => "cookie",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Environment => "environment",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCity => "geo_city",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCountry => "geo_country",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Header => "header",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Host => "host",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.IpAddress => "ip_address",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Method => "method",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Path => "path",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Protocol => "protocol",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Query => "query",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.RawPath => "raw_path",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Region => "region",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Route => "route",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Scheme => "scheme",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.ServerAction => "server_action",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.TargetPath => "target_path",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotCategory,
                "bot_name" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotName,
                "cookie" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Cookie,
                "environment" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Environment,
                "geo_as_number" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Header,
                "host" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Host,
                "ip_address" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Ja4Digest,
                "method" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Method,
                "path" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Path,
                "protocol" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Protocol,
                "query" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.RawPath,
                "region" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Region,
                "route" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Route,
                "scheme" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Scheme,
                "server_action" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.ServerAction,
                "target_path" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.TargetPath,
                "user_agent" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}