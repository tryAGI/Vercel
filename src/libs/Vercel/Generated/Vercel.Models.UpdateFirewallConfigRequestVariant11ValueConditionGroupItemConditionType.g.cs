
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType
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
    public static class UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.BotCategory => "bot_category",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.BotName => "bot_name",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.BotStatus => "bot_status",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Cookie => "cookie",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Environment => "environment",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.GeoCity => "geo_city",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.GeoContinent => "geo_continent",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.GeoCountry => "geo_country",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Header => "header",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Host => "host",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.IpAddress => "ip_address",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Method => "method",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Path => "path",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Protocol => "protocol",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Query => "query",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.RawPath => "raw_path",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Region => "region",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Route => "route",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Ruleset => "ruleset",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Scheme => "scheme",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.ServerAction => "server_action",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.SharedCondition => "shared_condition",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.TargetPath => "target_path",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.BotCategory,
                "bot_name" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.BotName,
                "bot_protection" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.BotProtection,
                "bot_status" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.BotStatus,
                "cookie" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Cookie,
                "domain_environment" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.DomainEnvironment,
                "environment" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Environment,
                "geo_as_number" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.GeoCity,
                "geo_continent" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.GeoContinent,
                "geo_country" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.GeoCountryRegion,
                "header" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Header,
                "host" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Host,
                "ip_address" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Ja4Digest,
                "method" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Method,
                "path" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Path,
                "protocol" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Protocol,
                "query" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.RawPath,
                "region" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Region,
                "route" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Route,
                "ruleset" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Ruleset,
                "scheme" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.Scheme,
                "server_action" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.ServerAction,
                "shared_condition" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.SharedCondition,
                "target_path" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.TargetPath,
                "user_agent" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}