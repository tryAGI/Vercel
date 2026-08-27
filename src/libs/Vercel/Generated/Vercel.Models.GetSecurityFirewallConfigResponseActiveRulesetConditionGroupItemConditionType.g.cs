
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType
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
    public static class GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}