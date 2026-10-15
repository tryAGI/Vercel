
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType
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
    public static class AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Header => "header",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Host => "host",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Method => "method",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Path => "path",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Query => "query",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Region => "region",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Route => "route",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Header,
                "host" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Method,
                "path" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.ResponseCode,
                "route" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}