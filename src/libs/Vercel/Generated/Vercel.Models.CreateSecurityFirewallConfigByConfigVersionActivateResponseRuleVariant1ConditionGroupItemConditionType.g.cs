
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.BotCategory => "bot_category",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.BotName => "bot_name",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.BotProtection => "bot_protection",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.BotStatus => "bot_status",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Cookie => "cookie",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Environment => "environment",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.GeoCity => "geo_city",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.GeoContinent => "geo_continent",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.GeoCountry => "geo_country",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Header => "header",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Host => "host",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.IpAddress => "ip_address",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Method => "method",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Path => "path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Protocol => "protocol",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Query => "query",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.RawPath => "raw_path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Region => "region",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Route => "route",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Ruleset => "ruleset",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Scheme => "scheme",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.ServerAction => "server_action",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.TargetPath => "target_path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.TrustedSource => "trusted_source",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.BotCategory,
                "bot_name" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.BotName,
                "bot_protection" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.BotProtection,
                "bot_status" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.BotStatus,
                "cookie" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Cookie,
                "domain_environment" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.DomainEnvironment,
                "environment" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Environment,
                "geo_as_number" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.GeoCity,
                "geo_continent" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.GeoContinent,
                "geo_country" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.GeoCountryRegion,
                "header" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Header,
                "host" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Host,
                "ip_address" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Ja4Digest,
                "method" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Method,
                "path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Path,
                "protocol" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Protocol,
                "query" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.RawPath,
                "region" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Region,
                "route" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Route,
                "ruleset" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Ruleset,
                "scheme" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.Scheme,
                "server_action" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.ServerAction,
                "target_path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.TargetPath,
                "trusted_source" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.TrustedSource,
                "user_agent" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}