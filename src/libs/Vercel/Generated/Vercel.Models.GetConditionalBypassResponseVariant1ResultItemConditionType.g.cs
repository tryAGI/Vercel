
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConditionalBypassResponseVariant1ResultItemConditionType
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
    public static class GetConditionalBypassResponseVariant1ResultItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConditionalBypassResponseVariant1ResultItemConditionType value)
        {
            return value switch
            {
                GetConditionalBypassResponseVariant1ResultItemConditionType.BotCategory => "bot_category",
                GetConditionalBypassResponseVariant1ResultItemConditionType.BotName => "bot_name",
                GetConditionalBypassResponseVariant1ResultItemConditionType.BotProtection => "bot_protection",
                GetConditionalBypassResponseVariant1ResultItemConditionType.BotStatus => "bot_status",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Cookie => "cookie",
                GetConditionalBypassResponseVariant1ResultItemConditionType.DomainEnvironment => "domain_environment",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Environment => "environment",
                GetConditionalBypassResponseVariant1ResultItemConditionType.GeoAsNumber => "geo_as_number",
                GetConditionalBypassResponseVariant1ResultItemConditionType.GeoCity => "geo_city",
                GetConditionalBypassResponseVariant1ResultItemConditionType.GeoContinent => "geo_continent",
                GetConditionalBypassResponseVariant1ResultItemConditionType.GeoCountry => "geo_country",
                GetConditionalBypassResponseVariant1ResultItemConditionType.GeoCountryRegion => "geo_country_region",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Header => "header",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Host => "host",
                GetConditionalBypassResponseVariant1ResultItemConditionType.IpAddress => "ip_address",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Ja3Digest => "ja3_digest",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Ja4Digest => "ja4_digest",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Method => "method",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Path => "path",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Protocol => "protocol",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Query => "query",
                GetConditionalBypassResponseVariant1ResultItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetConditionalBypassResponseVariant1ResultItemConditionType.RawPath => "raw_path",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Region => "region",
                GetConditionalBypassResponseVariant1ResultItemConditionType.ResponseCode => "response_code",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Route => "route",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Ruleset => "ruleset",
                GetConditionalBypassResponseVariant1ResultItemConditionType.Scheme => "scheme",
                GetConditionalBypassResponseVariant1ResultItemConditionType.ServerAction => "server_action",
                GetConditionalBypassResponseVariant1ResultItemConditionType.SharedCondition => "shared_condition",
                GetConditionalBypassResponseVariant1ResultItemConditionType.TargetPath => "target_path",
                GetConditionalBypassResponseVariant1ResultItemConditionType.TrafficSource => "traffic_source",
                GetConditionalBypassResponseVariant1ResultItemConditionType.TrustedSource => "trusted_source",
                GetConditionalBypassResponseVariant1ResultItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConditionalBypassResponseVariant1ResultItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetConditionalBypassResponseVariant1ResultItemConditionType.BotCategory,
                "bot_name" => GetConditionalBypassResponseVariant1ResultItemConditionType.BotName,
                "bot_protection" => GetConditionalBypassResponseVariant1ResultItemConditionType.BotProtection,
                "bot_status" => GetConditionalBypassResponseVariant1ResultItemConditionType.BotStatus,
                "cookie" => GetConditionalBypassResponseVariant1ResultItemConditionType.Cookie,
                "domain_environment" => GetConditionalBypassResponseVariant1ResultItemConditionType.DomainEnvironment,
                "environment" => GetConditionalBypassResponseVariant1ResultItemConditionType.Environment,
                "geo_as_number" => GetConditionalBypassResponseVariant1ResultItemConditionType.GeoAsNumber,
                "geo_city" => GetConditionalBypassResponseVariant1ResultItemConditionType.GeoCity,
                "geo_continent" => GetConditionalBypassResponseVariant1ResultItemConditionType.GeoContinent,
                "geo_country" => GetConditionalBypassResponseVariant1ResultItemConditionType.GeoCountry,
                "geo_country_region" => GetConditionalBypassResponseVariant1ResultItemConditionType.GeoCountryRegion,
                "header" => GetConditionalBypassResponseVariant1ResultItemConditionType.Header,
                "host" => GetConditionalBypassResponseVariant1ResultItemConditionType.Host,
                "ip_address" => GetConditionalBypassResponseVariant1ResultItemConditionType.IpAddress,
                "ja3_digest" => GetConditionalBypassResponseVariant1ResultItemConditionType.Ja3Digest,
                "ja4_digest" => GetConditionalBypassResponseVariant1ResultItemConditionType.Ja4Digest,
                "method" => GetConditionalBypassResponseVariant1ResultItemConditionType.Method,
                "path" => GetConditionalBypassResponseVariant1ResultItemConditionType.Path,
                "protocol" => GetConditionalBypassResponseVariant1ResultItemConditionType.Protocol,
                "query" => GetConditionalBypassResponseVariant1ResultItemConditionType.Query,
                "rate_limit_api_id" => GetConditionalBypassResponseVariant1ResultItemConditionType.RateLimitApiId,
                "raw_path" => GetConditionalBypassResponseVariant1ResultItemConditionType.RawPath,
                "region" => GetConditionalBypassResponseVariant1ResultItemConditionType.Region,
                "response_code" => GetConditionalBypassResponseVariant1ResultItemConditionType.ResponseCode,
                "route" => GetConditionalBypassResponseVariant1ResultItemConditionType.Route,
                "ruleset" => GetConditionalBypassResponseVariant1ResultItemConditionType.Ruleset,
                "scheme" => GetConditionalBypassResponseVariant1ResultItemConditionType.Scheme,
                "server_action" => GetConditionalBypassResponseVariant1ResultItemConditionType.ServerAction,
                "shared_condition" => GetConditionalBypassResponseVariant1ResultItemConditionType.SharedCondition,
                "target_path" => GetConditionalBypassResponseVariant1ResultItemConditionType.TargetPath,
                "traffic_source" => GetConditionalBypassResponseVariant1ResultItemConditionType.TrafficSource,
                "trusted_source" => GetConditionalBypassResponseVariant1ResultItemConditionType.TrustedSource,
                "user_agent" => GetConditionalBypassResponseVariant1ResultItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}