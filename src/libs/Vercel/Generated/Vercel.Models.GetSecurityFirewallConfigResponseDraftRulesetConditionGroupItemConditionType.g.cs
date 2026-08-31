
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType
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
    public static class GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.TrafficSource => "traffic_source",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.TargetPath,
                "traffic_source" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.TrafficSource,
                "trusted_source" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}