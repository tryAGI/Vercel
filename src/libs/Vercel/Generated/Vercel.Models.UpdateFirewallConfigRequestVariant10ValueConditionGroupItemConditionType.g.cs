
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType
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
    public static class UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.BotCategory => "bot_category",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.BotName => "bot_name",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.BotStatus => "bot_status",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Cookie => "cookie",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Environment => "environment",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.GeoCity => "geo_city",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.GeoContinent => "geo_continent",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.GeoCountry => "geo_country",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Header => "header",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Host => "host",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.IpAddress => "ip_address",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Method => "method",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Path => "path",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Protocol => "protocol",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Query => "query",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.RawPath => "raw_path",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Region => "region",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Route => "route",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Ruleset => "ruleset",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Scheme => "scheme",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.ServerAction => "server_action",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.SharedCondition => "shared_condition",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.TargetPath => "target_path",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.BotCategory,
                "bot_name" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.BotName,
                "bot_protection" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.BotProtection,
                "bot_status" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.BotStatus,
                "cookie" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Cookie,
                "domain_environment" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.DomainEnvironment,
                "environment" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Environment,
                "geo_as_number" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.GeoCity,
                "geo_continent" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.GeoContinent,
                "geo_country" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.GeoCountryRegion,
                "header" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Header,
                "host" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Host,
                "ip_address" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Ja4Digest,
                "method" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Method,
                "path" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Path,
                "protocol" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Protocol,
                "query" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.RawPath,
                "region" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Region,
                "route" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Route,
                "ruleset" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Ruleset,
                "scheme" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.Scheme,
                "server_action" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.ServerAction,
                "shared_condition" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.SharedCondition,
                "target_path" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.TargetPath,
                "user_agent" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}