
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.BotCategory => "bot_category",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.BotName => "bot_name",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.BotProtection => "bot_protection",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.BotStatus => "bot_status",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Cookie => "cookie",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Environment => "environment",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.GeoCity => "geo_city",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.GeoCountry => "geo_country",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Header => "header",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Host => "host",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.IpAddress => "ip_address",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Method => "method",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Path => "path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Protocol => "protocol",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Query => "query",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.RawPath => "raw_path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Region => "region",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Route => "route",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Ruleset => "ruleset",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Scheme => "scheme",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.ServerAction => "server_action",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.TargetPath => "target_path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.BotCategory,
                "bot_name" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.BotName,
                "bot_protection" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.BotProtection,
                "bot_status" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.BotStatus,
                "cookie" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Cookie,
                "domain_environment" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Environment,
                "geo_as_number" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Header,
                "host" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Host,
                "ip_address" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Ja4Digest,
                "method" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Method,
                "path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Path,
                "protocol" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Protocol,
                "query" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.RawPath,
                "region" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Region,
                "route" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Route,
                "ruleset" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Ruleset,
                "scheme" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.Scheme,
                "server_action" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.ServerAction,
                "target_path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.TargetPath,
                "trusted_source" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}