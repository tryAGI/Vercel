
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PutFirewallConfigRequestRulesetConditionGroupItemConditionType
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
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutFirewallConfigRequestRulesetConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRulesetConditionGroupItemConditionType value)
        {
            return value switch
            {
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.BotCategory => "bot_category",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.BotName => "bot_name",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.BotProtection => "bot_protection",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.BotStatus => "bot_status",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Cookie => "cookie",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Environment => "environment",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.GeoCity => "geo_city",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.GeoContinent => "geo_continent",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.GeoCountry => "geo_country",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Header => "header",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Host => "host",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.IpAddress => "ip_address",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Method => "method",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Path => "path",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Protocol => "protocol",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Query => "query",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.RawPath => "raw_path",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Region => "region",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Route => "route",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Ruleset => "ruleset",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Scheme => "scheme",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.ServerAction => "server_action",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.SharedCondition => "shared_condition",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.TargetPath => "target_path",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRulesetConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.BotCategory,
                "bot_name" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.BotName,
                "bot_protection" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.BotProtection,
                "bot_status" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.BotStatus,
                "cookie" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Cookie,
                "domain_environment" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.DomainEnvironment,
                "environment" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Environment,
                "geo_as_number" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.GeoCity,
                "geo_continent" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.GeoContinent,
                "geo_country" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.GeoCountryRegion,
                "header" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Header,
                "host" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Host,
                "ip_address" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Ja4Digest,
                "method" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Method,
                "path" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Path,
                "protocol" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Protocol,
                "query" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.RawPath,
                "region" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Region,
                "route" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Route,
                "ruleset" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Ruleset,
                "scheme" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.Scheme,
                "server_action" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.ServerAction,
                "shared_condition" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.SharedCondition,
                "target_path" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.TargetPath,
                "user_agent" => PutFirewallConfigRequestRulesetConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}