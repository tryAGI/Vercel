
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType
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
    public static class PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotCategory => "bot_category",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotName => "bot_name",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotProtection => "bot_protection",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotStatus => "bot_status",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Cookie => "cookie",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Environment => "environment",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCity => "geo_city",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoContinent => "geo_continent",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCountry => "geo_country",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Header => "header",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Host => "host",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.IpAddress => "ip_address",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Method => "method",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Path => "path",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Protocol => "protocol",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Query => "query",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.RawPath => "raw_path",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Region => "region",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Route => "route",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Scheme => "scheme",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.ServerAction => "server_action",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.TargetPath => "target_path",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.TrustedSource => "trusted_source",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotCategory,
                "bot_name" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotName,
                "bot_protection" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotProtection,
                "bot_status" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotStatus,
                "cookie" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Cookie,
                "environment" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Environment,
                "geo_as_number" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCity,
                "geo_continent" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoContinent,
                "geo_country" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCountryRegion,
                "header" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Header,
                "host" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Host,
                "ip_address" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Ja4Digest,
                "method" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Method,
                "path" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Path,
                "protocol" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Protocol,
                "query" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.RawPath,
                "region" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Region,
                "route" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Route,
                "scheme" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Scheme,
                "server_action" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.ServerAction,
                "target_path" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.TargetPath,
                "trusted_source" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.TrustedSource,
                "user_agent" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}