
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType
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
    public static class AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Header => "header",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Host => "host",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Method => "method",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Path => "path",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Query => "query",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Region => "region",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Route => "route",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.ResponseCode,
                "route" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}