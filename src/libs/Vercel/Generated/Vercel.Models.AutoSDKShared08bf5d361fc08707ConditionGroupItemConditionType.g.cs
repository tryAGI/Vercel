
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType
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
    public static class AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType value)
        {
            return value switch
            {
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.BotCategory => "bot_category",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.BotName => "bot_name",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.BotProtection => "bot_protection",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.BotStatus => "bot_status",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Cookie => "cookie",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Environment => "environment",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.GeoCity => "geo_city",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.GeoCountry => "geo_country",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Header => "header",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Host => "host",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.IpAddress => "ip_address",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Method => "method",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Path => "path",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Protocol => "protocol",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Query => "query",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.RawPath => "raw_path",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Region => "region",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Route => "route",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Ruleset => "ruleset",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Scheme => "scheme",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.ServerAction => "server_action",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.TargetPath => "target_path",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.TrafficSource => "traffic_source",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.BotCategory,
                "bot_name" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.BotName,
                "bot_protection" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.BotProtection,
                "bot_status" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.BotStatus,
                "cookie" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Cookie,
                "domain_environment" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Environment,
                "geo_as_number" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Header,
                "host" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Host,
                "ip_address" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Ja4Digest,
                "method" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Method,
                "path" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Path,
                "protocol" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Protocol,
                "query" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.RawPath,
                "region" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Region,
                "route" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Route,
                "ruleset" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Ruleset,
                "scheme" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.Scheme,
                "server_action" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.SharedCondition,
                "target_path" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.TargetPath,
                "traffic_source" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}