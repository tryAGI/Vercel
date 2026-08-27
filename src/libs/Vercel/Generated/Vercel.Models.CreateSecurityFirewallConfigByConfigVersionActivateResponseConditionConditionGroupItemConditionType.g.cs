
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.BotCategory => "bot_category",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.BotName => "bot_name",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.BotProtection => "bot_protection",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.BotStatus => "bot_status",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Cookie => "cookie",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Environment => "environment",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.GeoCity => "geo_city",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.GeoContinent => "geo_continent",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.GeoCountry => "geo_country",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Header => "header",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Host => "host",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.IpAddress => "ip_address",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Method => "method",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Path => "path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Protocol => "protocol",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Query => "query",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.RawPath => "raw_path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Region => "region",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Route => "route",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Ruleset => "ruleset",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Scheme => "scheme",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.ServerAction => "server_action",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.SharedCondition => "shared_condition",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.TargetPath => "target_path",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.TrustedSource => "trusted_source",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.BotCategory,
                "bot_name" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.BotName,
                "bot_protection" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.BotProtection,
                "bot_status" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.BotStatus,
                "cookie" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Cookie,
                "domain_environment" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.DomainEnvironment,
                "environment" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Environment,
                "geo_as_number" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.GeoCity,
                "geo_continent" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.GeoContinent,
                "geo_country" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.GeoCountryRegion,
                "header" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Header,
                "host" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Host,
                "ip_address" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Ja4Digest,
                "method" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Method,
                "path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Path,
                "protocol" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Protocol,
                "query" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.RawPath,
                "region" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Region,
                "route" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Route,
                "ruleset" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Ruleset,
                "scheme" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.Scheme,
                "server_action" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.ServerAction,
                "shared_condition" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.SharedCondition,
                "target_path" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.TargetPath,
                "trusted_source" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.TrustedSource,
                "user_agent" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}