
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRulesetConditionGroupItemConditionType
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
        TrustedSource,
        /// <summary>
        /// 
        /// </summary>
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFirewallConfigResponseRulesetConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRulesetConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.BotCategory => "bot_category",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.BotName => "bot_name",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.BotStatus => "bot_status",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Cookie => "cookie",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Environment => "environment",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.GeoCity => "geo_city",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Header => "header",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Host => "host",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.IpAddress => "ip_address",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Method => "method",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Path => "path",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Protocol => "protocol",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Query => "query",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.RawPath => "raw_path",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Region => "region",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Route => "route",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Scheme => "scheme",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.ServerAction => "server_action",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.TargetPath => "target_path",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRulesetConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.BotName,
                "bot_protection" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.BotStatus,
                "cookie" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Cookie,
                "environment" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Header,
                "host" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Host,
                "ip_address" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Ja4Digest,
                "method" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Method,
                "path" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Path,
                "protocol" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Protocol,
                "query" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.RawPath,
                "region" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Region,
                "route" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Route,
                "scheme" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.Scheme,
                "server_action" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.ServerAction,
                "target_path" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetFirewallConfigResponseRulesetConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}