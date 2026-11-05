
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType
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
    public static class AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Environment => "environment",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Header => "header",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Host => "host",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Method => "method",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Path => "path",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Query => "query",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Region => "region",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.ResponseHeader => "response_header",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Route => "route",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Header,
                "host" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Method,
                "path" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.ResponseCode,
                "response_header" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.ResponseHeader,
                "route" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}