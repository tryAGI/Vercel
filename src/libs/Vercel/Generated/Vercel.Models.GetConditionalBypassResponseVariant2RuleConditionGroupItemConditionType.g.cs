
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType
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
    public static class GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.BotCategory => "bot_category",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.BotName => "bot_name",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.BotStatus => "bot_status",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Cookie => "cookie",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Environment => "environment",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.GeoCity => "geo_city",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Header => "header",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Host => "host",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.IpAddress => "ip_address",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Method => "method",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Path => "path",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Protocol => "protocol",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Query => "query",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.RawPath => "raw_path",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Region => "region",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.ResponseCode => "response_code",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Route => "route",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Ruleset => "ruleset",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Scheme => "scheme",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.ServerAction => "server_action",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.TargetPath => "target_path",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.TrafficSource => "traffic_source",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.BotName,
                "bot_protection" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.BotStatus,
                "cookie" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Header,
                "host" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Host,
                "ip_address" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Ja4Digest,
                "method" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Method,
                "path" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Path,
                "protocol" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Protocol,
                "query" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.RawPath,
                "region" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Region,
                "response_code" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.ResponseCode,
                "route" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Route,
                "ruleset" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Ruleset,
                "scheme" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.Scheme,
                "server_action" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.TargetPath,
                "traffic_source" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}