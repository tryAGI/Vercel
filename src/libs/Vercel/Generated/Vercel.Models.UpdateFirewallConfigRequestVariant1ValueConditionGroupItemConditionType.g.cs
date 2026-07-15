
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType
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
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.BotCategory => "bot_category",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.BotName => "bot_name",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.BotStatus => "bot_status",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Cookie => "cookie",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.DomainEnvironment => "domain_environment",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Environment => "environment",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.GeoCity => "geo_city",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.GeoContinent => "geo_continent",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.GeoCountry => "geo_country",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Header => "header",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Host => "host",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.IpAddress => "ip_address",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Method => "method",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Path => "path",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Protocol => "protocol",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Query => "query",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.RawPath => "raw_path",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Region => "region",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Route => "route",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Ruleset => "ruleset",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Scheme => "scheme",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.ServerAction => "server_action",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.TargetPath => "target_path",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.BotCategory,
                "bot_name" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.BotName,
                "bot_protection" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.BotProtection,
                "bot_status" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.BotStatus,
                "cookie" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Cookie,
                "domain_environment" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.DomainEnvironment,
                "environment" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Environment,
                "geo_as_number" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.GeoCity,
                "geo_continent" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.GeoContinent,
                "geo_country" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.GeoCountryRegion,
                "header" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Header,
                "host" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Host,
                "ip_address" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Ja4Digest,
                "method" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Method,
                "path" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Path,
                "protocol" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Protocol,
                "query" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.RawPath,
                "region" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Region,
                "route" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Route,
                "ruleset" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Ruleset,
                "scheme" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.Scheme,
                "server_action" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.ServerAction,
                "target_path" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.TargetPath,
                "user_agent" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}