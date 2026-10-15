
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType
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
    public static class AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Header => "header",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Host => "host",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Method => "method",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Path => "path",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Query => "query",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Region => "region",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.ResponseCode => "response_code",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Route => "route",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Region,
                "response_code" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.ResponseCode,
                "route" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}