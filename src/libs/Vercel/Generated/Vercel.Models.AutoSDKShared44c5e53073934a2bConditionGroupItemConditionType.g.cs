
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType
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
        ResponseHeader,
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
    public static class AutoSDKShared44c5e53073934a2bConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Header => "header",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Host => "host",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Method => "method",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Path => "path",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Query => "query",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Region => "region",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.ResponseHeader => "response_header",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Route => "route",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.ResponseCode,
                "response_header" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.ResponseHeader,
                "route" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}