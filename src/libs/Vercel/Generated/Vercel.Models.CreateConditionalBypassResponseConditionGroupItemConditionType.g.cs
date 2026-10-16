
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassResponseConditionGroupItemConditionType
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
    public static class CreateConditionalBypassResponseConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassResponseConditionGroupItemConditionType value)
        {
            return value switch
            {
                CreateConditionalBypassResponseConditionGroupItemConditionType.BotCategory => "bot_category",
                CreateConditionalBypassResponseConditionGroupItemConditionType.BotName => "bot_name",
                CreateConditionalBypassResponseConditionGroupItemConditionType.BotProtection => "bot_protection",
                CreateConditionalBypassResponseConditionGroupItemConditionType.BotStatus => "bot_status",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Cookie => "cookie",
                CreateConditionalBypassResponseConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Environment => "environment",
                CreateConditionalBypassResponseConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                CreateConditionalBypassResponseConditionGroupItemConditionType.GeoCity => "geo_city",
                CreateConditionalBypassResponseConditionGroupItemConditionType.GeoContinent => "geo_continent",
                CreateConditionalBypassResponseConditionGroupItemConditionType.GeoCountry => "geo_country",
                CreateConditionalBypassResponseConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Header => "header",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Host => "host",
                CreateConditionalBypassResponseConditionGroupItemConditionType.IpAddress => "ip_address",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Method => "method",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Path => "path",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Protocol => "protocol",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Query => "query",
                CreateConditionalBypassResponseConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                CreateConditionalBypassResponseConditionGroupItemConditionType.RawPath => "raw_path",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Region => "region",
                CreateConditionalBypassResponseConditionGroupItemConditionType.ResponseCode => "response_code",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Route => "route",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Ruleset => "ruleset",
                CreateConditionalBypassResponseConditionGroupItemConditionType.Scheme => "scheme",
                CreateConditionalBypassResponseConditionGroupItemConditionType.ServerAction => "server_action",
                CreateConditionalBypassResponseConditionGroupItemConditionType.SharedCondition => "shared_condition",
                CreateConditionalBypassResponseConditionGroupItemConditionType.TargetPath => "target_path",
                CreateConditionalBypassResponseConditionGroupItemConditionType.TrafficSource => "traffic_source",
                CreateConditionalBypassResponseConditionGroupItemConditionType.TrustedSource => "trusted_source",
                CreateConditionalBypassResponseConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassResponseConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => CreateConditionalBypassResponseConditionGroupItemConditionType.BotCategory,
                "bot_name" => CreateConditionalBypassResponseConditionGroupItemConditionType.BotName,
                "bot_protection" => CreateConditionalBypassResponseConditionGroupItemConditionType.BotProtection,
                "bot_status" => CreateConditionalBypassResponseConditionGroupItemConditionType.BotStatus,
                "cookie" => CreateConditionalBypassResponseConditionGroupItemConditionType.Cookie,
                "domain_environment" => CreateConditionalBypassResponseConditionGroupItemConditionType.DomainEnvironment,
                "environment" => CreateConditionalBypassResponseConditionGroupItemConditionType.Environment,
                "geo_as_number" => CreateConditionalBypassResponseConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => CreateConditionalBypassResponseConditionGroupItemConditionType.GeoCity,
                "geo_continent" => CreateConditionalBypassResponseConditionGroupItemConditionType.GeoContinent,
                "geo_country" => CreateConditionalBypassResponseConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => CreateConditionalBypassResponseConditionGroupItemConditionType.GeoCountryRegion,
                "header" => CreateConditionalBypassResponseConditionGroupItemConditionType.Header,
                "host" => CreateConditionalBypassResponseConditionGroupItemConditionType.Host,
                "ip_address" => CreateConditionalBypassResponseConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => CreateConditionalBypassResponseConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => CreateConditionalBypassResponseConditionGroupItemConditionType.Ja4Digest,
                "method" => CreateConditionalBypassResponseConditionGroupItemConditionType.Method,
                "path" => CreateConditionalBypassResponseConditionGroupItemConditionType.Path,
                "protocol" => CreateConditionalBypassResponseConditionGroupItemConditionType.Protocol,
                "query" => CreateConditionalBypassResponseConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => CreateConditionalBypassResponseConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => CreateConditionalBypassResponseConditionGroupItemConditionType.RawPath,
                "region" => CreateConditionalBypassResponseConditionGroupItemConditionType.Region,
                "response_code" => CreateConditionalBypassResponseConditionGroupItemConditionType.ResponseCode,
                "route" => CreateConditionalBypassResponseConditionGroupItemConditionType.Route,
                "ruleset" => CreateConditionalBypassResponseConditionGroupItemConditionType.Ruleset,
                "scheme" => CreateConditionalBypassResponseConditionGroupItemConditionType.Scheme,
                "server_action" => CreateConditionalBypassResponseConditionGroupItemConditionType.ServerAction,
                "shared_condition" => CreateConditionalBypassResponseConditionGroupItemConditionType.SharedCondition,
                "target_path" => CreateConditionalBypassResponseConditionGroupItemConditionType.TargetPath,
                "traffic_source" => CreateConditionalBypassResponseConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => CreateConditionalBypassResponseConditionGroupItemConditionType.TrustedSource,
                "user_agent" => CreateConditionalBypassResponseConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}