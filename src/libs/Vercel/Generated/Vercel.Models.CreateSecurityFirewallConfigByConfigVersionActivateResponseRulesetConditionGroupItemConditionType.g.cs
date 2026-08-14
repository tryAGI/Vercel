
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.BotCategory => "bot_category",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.BotName => "bot_name",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.BotProtection => "bot_protection",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.BotStatus => "bot_status",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Cookie => "cookie",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Environment => "environment",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.GeoCity => "geo_city",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.GeoContinent => "geo_continent",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.GeoCountry => "geo_country",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Header => "header",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Host => "host",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.IpAddress => "ip_address",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Method => "method",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Path => "path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Protocol => "protocol",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Query => "query",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.RawPath => "raw_path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Region => "region",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Route => "route",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Ruleset => "ruleset",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Scheme => "scheme",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.ServerAction => "server_action",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.SharedCondition => "shared_condition",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.TargetPath => "target_path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.TrustedSource => "trusted_source",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.BotCategory,
                "bot_name" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.BotName,
                "bot_protection" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.BotProtection,
                "bot_status" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.BotStatus,
                "cookie" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Cookie,
                "domain_environment" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.DomainEnvironment,
                "environment" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Environment,
                "geo_as_number" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.GeoCity,
                "geo_continent" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.GeoContinent,
                "geo_country" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.GeoCountryRegion,
                "header" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Header,
                "host" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Host,
                "ip_address" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Ja4Digest,
                "method" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Method,
                "path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Path,
                "protocol" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Protocol,
                "query" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.RawPath,
                "region" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Region,
                "route" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Route,
                "ruleset" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Ruleset,
                "scheme" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.Scheme,
                "server_action" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.ServerAction,
                "shared_condition" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.SharedCondition,
                "target_path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.TargetPath,
                "trusted_source" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.TrustedSource,
                "user_agent" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}