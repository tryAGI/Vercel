
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType
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
    public static class AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Environment => "environment",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Header => "header",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Host => "host",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Method => "method",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Path => "path",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Query => "query",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Region => "region",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.ResponseHeader => "response_header",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Route => "route",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Header,
                "host" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Method,
                "path" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.ResponseCode,
                "response_header" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.ResponseHeader,
                "route" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}