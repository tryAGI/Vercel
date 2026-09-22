
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType
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
    public static class AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Header => "header",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Host => "host",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Method => "method",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Path => "path",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Query => "query",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Region => "region",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Route => "route",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Region,
                "route" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}