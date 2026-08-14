
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType
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
    public static class GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.BotCategory => "bot_category",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.BotName => "bot_name",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.BotProtection => "bot_protection",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.BotStatus => "bot_status",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Cookie => "cookie",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Environment => "environment",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.GeoCity => "geo_city",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.GeoContinent => "geo_continent",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.GeoCountry => "geo_country",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Header => "header",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Host => "host",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.IpAddress => "ip_address",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Method => "method",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Path => "path",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Protocol => "protocol",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Query => "query",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.RawPath => "raw_path",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Region => "region",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Route => "route",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Ruleset => "ruleset",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Scheme => "scheme",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.ServerAction => "server_action",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.SharedCondition => "shared_condition",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.TargetPath => "target_path",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.TrustedSource => "trusted_source",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.BotCategory,
                "bot_name" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.BotName,
                "bot_protection" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.BotProtection,
                "bot_status" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.BotStatus,
                "cookie" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Cookie,
                "domain_environment" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.DomainEnvironment,
                "environment" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Environment,
                "geo_as_number" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.GeoCity,
                "geo_continent" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.GeoContinent,
                "geo_country" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.GeoCountryRegion,
                "header" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Header,
                "host" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Host,
                "ip_address" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Ja4Digest,
                "method" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Method,
                "path" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Path,
                "protocol" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Protocol,
                "query" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.RawPath,
                "region" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Region,
                "route" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Route,
                "ruleset" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Ruleset,
                "scheme" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.Scheme,
                "server_action" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.ServerAction,
                "shared_condition" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.SharedCondition,
                "target_path" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.TargetPath,
                "trusted_source" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.TrustedSource,
                "user_agent" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}