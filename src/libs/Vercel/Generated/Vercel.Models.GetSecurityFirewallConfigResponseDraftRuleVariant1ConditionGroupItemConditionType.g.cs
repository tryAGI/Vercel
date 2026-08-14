
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType
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
    public static class GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}