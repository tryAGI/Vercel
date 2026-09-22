
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType
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
        TrustedSource,
        /// <summary>
        ///
        /// </summary>
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Environment => "environment",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Header => "header",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Host => "host",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Method => "method",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Path => "path",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Query => "query",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Region => "region",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Route => "route",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Header,
                "host" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Method,
                "path" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Region,
                "route" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}