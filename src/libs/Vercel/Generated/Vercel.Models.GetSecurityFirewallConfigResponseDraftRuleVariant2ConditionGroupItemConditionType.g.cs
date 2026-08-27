
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType
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
    public static class GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}