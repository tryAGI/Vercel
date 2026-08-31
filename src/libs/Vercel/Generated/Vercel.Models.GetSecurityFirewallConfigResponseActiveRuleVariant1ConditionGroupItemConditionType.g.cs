
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType
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
    public static class GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.TrafficSource => "traffic_source",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.TargetPath,
                "traffic_source" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}