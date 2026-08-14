
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType
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
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.BotCategory => "bot_category",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.BotName => "bot_name",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.BotStatus => "bot_status",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Cookie => "cookie",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Environment => "environment",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.GeoCity => "geo_city",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.GeoContinent => "geo_continent",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.GeoCountry => "geo_country",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Header => "header",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Host => "host",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.IpAddress => "ip_address",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Method => "method",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Path => "path",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Protocol => "protocol",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Query => "query",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.RawPath => "raw_path",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Region => "region",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Route => "route",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Ruleset => "ruleset",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Scheme => "scheme",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.ServerAction => "server_action",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.SharedCondition => "shared_condition",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.TargetPath => "target_path",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.BotCategory,
                "bot_name" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.BotName,
                "bot_protection" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.BotProtection,
                "bot_status" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.BotStatus,
                "cookie" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Cookie,
                "domain_environment" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.DomainEnvironment,
                "environment" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Environment,
                "geo_as_number" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.GeoCity,
                "geo_continent" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.GeoContinent,
                "geo_country" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.GeoCountryRegion,
                "header" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Header,
                "host" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Host,
                "ip_address" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Ja4Digest,
                "method" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Method,
                "path" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Path,
                "protocol" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Protocol,
                "query" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.RawPath,
                "region" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Region,
                "route" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Route,
                "ruleset" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Ruleset,
                "scheme" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.Scheme,
                "server_action" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.ServerAction,
                "shared_condition" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.SharedCondition,
                "target_path" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.TargetPath,
                "user_agent" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}