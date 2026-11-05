
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType
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
    public static class AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Environment => "environment",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Header => "header",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Host => "host",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Method => "method",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Path => "path",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Query => "query",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Region => "region",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.ResponseHeader => "response_header",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Route => "route",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Header,
                "host" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Method,
                "path" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.ResponseCode,
                "response_header" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.ResponseHeader,
                "route" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}