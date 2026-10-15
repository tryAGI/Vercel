
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType
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
    public static class AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Header => "header",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Host => "host",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Method => "method",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Path => "path",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Query => "query",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Region => "region",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Route => "route",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.ResponseCode,
                "route" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}