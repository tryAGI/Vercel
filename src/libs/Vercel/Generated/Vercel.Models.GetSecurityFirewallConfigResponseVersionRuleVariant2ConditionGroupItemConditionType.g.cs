
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType
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
        TrustedSource,
        /// <summary>
        ///
        /// </summary>
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}