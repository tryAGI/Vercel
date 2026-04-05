
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType
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
    public static class UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.BotCategory => "bot_category",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.BotName => "bot_name",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Cookie => "cookie",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Environment => "environment",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.GeoCity => "geo_city",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.GeoContinent => "geo_continent",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.GeoCountry => "geo_country",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Header => "header",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Host => "host",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.IpAddress => "ip_address",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Method => "method",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Path => "path",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Protocol => "protocol",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Query => "query",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.RawPath => "raw_path",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Region => "region",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Route => "route",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Scheme => "scheme",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.ServerAction => "server_action",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.TargetPath => "target_path",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.BotCategory,
                "bot_name" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.BotName,
                "cookie" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Cookie,
                "environment" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Environment,
                "geo_as_number" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.GeoCity,
                "geo_continent" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.GeoContinent,
                "geo_country" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.GeoCountryRegion,
                "header" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Header,
                "host" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Host,
                "ip_address" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Ja4Digest,
                "method" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Method,
                "path" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Path,
                "protocol" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Protocol,
                "query" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.RawPath,
                "region" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Region,
                "route" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Route,
                "scheme" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.Scheme,
                "server_action" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.ServerAction,
                "target_path" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.TargetPath,
                "user_agent" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}