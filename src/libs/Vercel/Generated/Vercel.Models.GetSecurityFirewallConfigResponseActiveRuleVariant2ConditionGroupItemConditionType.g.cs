
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType
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
    public static class GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}