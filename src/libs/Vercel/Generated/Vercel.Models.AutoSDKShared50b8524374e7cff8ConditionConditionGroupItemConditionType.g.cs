
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType
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
        ResponseCode,
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
    public static class AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Header => "header",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Host => "host",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Method => "method",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Path => "path",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Query => "query",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Region => "region",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Route => "route",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.ResponseCode,
                "route" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}