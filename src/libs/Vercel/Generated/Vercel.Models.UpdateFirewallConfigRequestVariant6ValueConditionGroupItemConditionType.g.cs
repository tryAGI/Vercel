
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType
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
        TrafficSource,
        /// <summary>
        ///
        /// </summary>
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.BotCategory => "bot_category",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.BotName => "bot_name",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.BotStatus => "bot_status",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Cookie => "cookie",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Environment => "environment",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.GeoCity => "geo_city",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.GeoContinent => "geo_continent",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.GeoCountry => "geo_country",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Header => "header",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Host => "host",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.IpAddress => "ip_address",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Method => "method",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Path => "path",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Protocol => "protocol",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Query => "query",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.RawPath => "raw_path",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Region => "region",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Route => "route",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Ruleset => "ruleset",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Scheme => "scheme",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.ServerAction => "server_action",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.SharedCondition => "shared_condition",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.TargetPath => "target_path",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.TrafficSource => "traffic_source",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.BotCategory,
                "bot_name" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.BotName,
                "bot_protection" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.BotProtection,
                "bot_status" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.BotStatus,
                "cookie" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Cookie,
                "domain_environment" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.DomainEnvironment,
                "environment" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Environment,
                "geo_as_number" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.GeoCity,
                "geo_continent" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.GeoContinent,
                "geo_country" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.GeoCountryRegion,
                "header" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Header,
                "host" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Host,
                "ip_address" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Ja4Digest,
                "method" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Method,
                "path" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Path,
                "protocol" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Protocol,
                "query" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.RawPath,
                "region" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Region,
                "route" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Route,
                "ruleset" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Ruleset,
                "scheme" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.Scheme,
                "server_action" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.ServerAction,
                "shared_condition" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.SharedCondition,
                "target_path" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.TargetPath,
                "traffic_source" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.TrafficSource,
                "user_agent" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}