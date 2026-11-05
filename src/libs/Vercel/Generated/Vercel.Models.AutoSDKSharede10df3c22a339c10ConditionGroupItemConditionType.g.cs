
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType
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
    public static class AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Environment => "environment",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Header => "header",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Host => "host",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Method => "method",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Path => "path",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Query => "query",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Region => "region",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.ResponseHeader => "response_header",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Route => "route",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Header,
                "host" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Method,
                "path" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.ResponseCode,
                "response_header" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.ResponseHeader,
                "route" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}