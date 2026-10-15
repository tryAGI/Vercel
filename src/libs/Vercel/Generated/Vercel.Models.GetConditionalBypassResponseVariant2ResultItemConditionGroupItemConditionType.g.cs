
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType
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
    public static class GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.BotCategory => "bot_category",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.BotName => "bot_name",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.BotStatus => "bot_status",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Cookie => "cookie",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Environment => "environment",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.GeoCity => "geo_city",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Header => "header",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Host => "host",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.IpAddress => "ip_address",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Method => "method",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Path => "path",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Protocol => "protocol",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Query => "query",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.RawPath => "raw_path",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Region => "region",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.ResponseCode => "response_code",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Route => "route",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Ruleset => "ruleset",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Scheme => "scheme",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.ServerAction => "server_action",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.TargetPath => "target_path",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.TrafficSource => "traffic_source",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.BotName,
                "bot_protection" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.BotStatus,
                "cookie" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Header,
                "host" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Host,
                "ip_address" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Ja4Digest,
                "method" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Method,
                "path" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Path,
                "protocol" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Protocol,
                "query" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.RawPath,
                "region" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Region,
                "response_code" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.ResponseCode,
                "route" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Route,
                "ruleset" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Ruleset,
                "scheme" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.Scheme,
                "server_action" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.TargetPath,
                "traffic_source" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}