
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType
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
    public static class AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Environment => "environment",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Header => "header",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Host => "host",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Method => "method",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Path => "path",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Query => "query",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Region => "region",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Route => "route",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Header,
                "host" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Method,
                "path" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Region,
                "route" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}