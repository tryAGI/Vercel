
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType
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
    public static class AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Header => "header",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Host => "host",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Method => "method",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Path => "path",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Query => "query",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Region => "region",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.ResponseHeader => "response_header",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Route => "route",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.ResponseCode,
                "response_header" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.ResponseHeader,
                "route" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}