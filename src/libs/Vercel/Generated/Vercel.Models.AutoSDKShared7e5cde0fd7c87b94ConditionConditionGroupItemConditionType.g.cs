
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType
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
    public static class AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Header => "header",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Host => "host",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Method => "method",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Path => "path",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Query => "query",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Region => "region",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Route => "route",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Region,
                "route" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}