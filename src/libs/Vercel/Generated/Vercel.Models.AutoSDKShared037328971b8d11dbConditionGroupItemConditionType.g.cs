
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared037328971b8d11dbConditionGroupItemConditionType
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
    public static class AutoSDKShared037328971b8d11dbConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared037328971b8d11dbConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Header => "header",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Host => "host",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Method => "method",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Path => "path",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Query => "query",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Region => "region",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Route => "route",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared037328971b8d11dbConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.ResponseCode,
                "route" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}