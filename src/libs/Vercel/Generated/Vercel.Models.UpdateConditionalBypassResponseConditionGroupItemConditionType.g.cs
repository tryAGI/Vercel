
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConditionalBypassResponseConditionGroupItemConditionType
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
    public static class UpdateConditionalBypassResponseConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConditionalBypassResponseConditionGroupItemConditionType value)
        {
            return value switch
            {
                UpdateConditionalBypassResponseConditionGroupItemConditionType.BotCategory => "bot_category",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.BotName => "bot_name",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.BotProtection => "bot_protection",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.BotStatus => "bot_status",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Cookie => "cookie",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Environment => "environment",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.GeoCity => "geo_city",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.GeoContinent => "geo_continent",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.GeoCountry => "geo_country",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Header => "header",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Host => "host",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.IpAddress => "ip_address",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Method => "method",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Path => "path",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Protocol => "protocol",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Query => "query",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.RawPath => "raw_path",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Region => "region",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.ResponseCode => "response_code",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Route => "route",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Ruleset => "ruleset",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.Scheme => "scheme",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.ServerAction => "server_action",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.SharedCondition => "shared_condition",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.TargetPath => "target_path",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.TrafficSource => "traffic_source",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.TrustedSource => "trusted_source",
                UpdateConditionalBypassResponseConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConditionalBypassResponseConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => UpdateConditionalBypassResponseConditionGroupItemConditionType.BotCategory,
                "bot_name" => UpdateConditionalBypassResponseConditionGroupItemConditionType.BotName,
                "bot_protection" => UpdateConditionalBypassResponseConditionGroupItemConditionType.BotProtection,
                "bot_status" => UpdateConditionalBypassResponseConditionGroupItemConditionType.BotStatus,
                "cookie" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Cookie,
                "domain_environment" => UpdateConditionalBypassResponseConditionGroupItemConditionType.DomainEnvironment,
                "environment" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Environment,
                "geo_as_number" => UpdateConditionalBypassResponseConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => UpdateConditionalBypassResponseConditionGroupItemConditionType.GeoCity,
                "geo_continent" => UpdateConditionalBypassResponseConditionGroupItemConditionType.GeoContinent,
                "geo_country" => UpdateConditionalBypassResponseConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => UpdateConditionalBypassResponseConditionGroupItemConditionType.GeoCountryRegion,
                "header" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Header,
                "host" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Host,
                "ip_address" => UpdateConditionalBypassResponseConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Ja4Digest,
                "method" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Method,
                "path" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Path,
                "protocol" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Protocol,
                "query" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => UpdateConditionalBypassResponseConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => UpdateConditionalBypassResponseConditionGroupItemConditionType.RawPath,
                "region" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Region,
                "response_code" => UpdateConditionalBypassResponseConditionGroupItemConditionType.ResponseCode,
                "route" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Route,
                "ruleset" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Ruleset,
                "scheme" => UpdateConditionalBypassResponseConditionGroupItemConditionType.Scheme,
                "server_action" => UpdateConditionalBypassResponseConditionGroupItemConditionType.ServerAction,
                "shared_condition" => UpdateConditionalBypassResponseConditionGroupItemConditionType.SharedCondition,
                "target_path" => UpdateConditionalBypassResponseConditionGroupItemConditionType.TargetPath,
                "traffic_source" => UpdateConditionalBypassResponseConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => UpdateConditionalBypassResponseConditionGroupItemConditionType.TrustedSource,
                "user_agent" => UpdateConditionalBypassResponseConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}