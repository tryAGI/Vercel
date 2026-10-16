
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConditionalBypassResponseVariant1ConditionGroupItemConditionType
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
    public static class GetConditionalBypassResponseVariant1ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConditionalBypassResponseVariant1ConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.BotCategory => "bot_category",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.BotName => "bot_name",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.BotStatus => "bot_status",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Cookie => "cookie",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Environment => "environment",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.GeoCity => "geo_city",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Header => "header",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Host => "host",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.IpAddress => "ip_address",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Method => "method",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Path => "path",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Protocol => "protocol",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Query => "query",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.RawPath => "raw_path",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Region => "region",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.ResponseCode => "response_code",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Route => "route",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Ruleset => "ruleset",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Scheme => "scheme",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.ServerAction => "server_action",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.TargetPath => "target_path",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.TrafficSource => "traffic_source",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConditionalBypassResponseVariant1ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.BotName,
                "bot_protection" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.BotStatus,
                "cookie" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Header,
                "host" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Host,
                "ip_address" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Ja4Digest,
                "method" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Method,
                "path" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Path,
                "protocol" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Protocol,
                "query" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.RawPath,
                "region" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Region,
                "response_code" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.ResponseCode,
                "route" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Route,
                "ruleset" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Ruleset,
                "scheme" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.Scheme,
                "server_action" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.TargetPath,
                "traffic_source" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}