
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType
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
    public static class AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Header => "header",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Host => "host",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Method => "method",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Path => "path",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Query => "query",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Region => "region",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Route => "route",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Region,
                "route" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}