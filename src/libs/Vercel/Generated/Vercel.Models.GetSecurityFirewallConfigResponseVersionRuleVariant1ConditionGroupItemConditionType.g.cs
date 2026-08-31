
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType
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
    public static class GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.TrafficSource => "traffic_source",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.TargetPath,
                "traffic_source" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}