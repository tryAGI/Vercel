
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassResponseResultConditionGroupItemConditionType
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
    public static class CreateConditionalBypassResponseResultConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassResponseResultConditionGroupItemConditionType value)
        {
            return value switch
            {
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.BotCategory => "bot_category",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.BotName => "bot_name",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.BotProtection => "bot_protection",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.BotStatus => "bot_status",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Cookie => "cookie",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Environment => "environment",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.GeoCity => "geo_city",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.GeoContinent => "geo_continent",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.GeoCountry => "geo_country",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Header => "header",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Host => "host",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.IpAddress => "ip_address",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Method => "method",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Path => "path",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Protocol => "protocol",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Query => "query",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.RawPath => "raw_path",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Region => "region",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.ResponseCode => "response_code",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Route => "route",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Ruleset => "ruleset",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.Scheme => "scheme",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.ServerAction => "server_action",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.SharedCondition => "shared_condition",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.TargetPath => "target_path",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.TrafficSource => "traffic_source",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.TrustedSource => "trusted_source",
                CreateConditionalBypassResponseResultConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassResponseResultConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.BotCategory,
                "bot_name" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.BotName,
                "bot_protection" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.BotProtection,
                "bot_status" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.BotStatus,
                "cookie" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Cookie,
                "domain_environment" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.DomainEnvironment,
                "environment" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Environment,
                "geo_as_number" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.GeoCity,
                "geo_continent" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.GeoContinent,
                "geo_country" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.GeoCountryRegion,
                "header" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Header,
                "host" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Host,
                "ip_address" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Ja4Digest,
                "method" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Method,
                "path" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Path,
                "protocol" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Protocol,
                "query" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.RawPath,
                "region" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Region,
                "response_code" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.ResponseCode,
                "route" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Route,
                "ruleset" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Ruleset,
                "scheme" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.Scheme,
                "server_action" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.ServerAction,
                "shared_condition" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.SharedCondition,
                "target_path" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.TargetPath,
                "traffic_source" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.TrustedSource,
                "user_agent" => CreateConditionalBypassResponseResultConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}