
#nullable enable

namespace Vercel
{
    /// <summary>
    /// [Parameter](https://vercel.com/docs/security/vercel-waf/rule-configuration#parameters) from the incoming traffic.
    /// </summary>
    public enum PutFirewallConfigRequestRuleConditionGroupItemConditionType
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
    public static class PutFirewallConfigRequestRuleConditionGroupItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRuleConditionGroupItemConditionType value)
        {
            return value switch
            {
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.BotCategory => "bot_category",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.BotName => "bot_name",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.BotProtection => "bot_protection",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.BotStatus => "bot_status",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Cookie => "cookie",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Environment => "environment",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.GeoAsNumber => "geo_as_number",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.GeoCity => "geo_city",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.GeoContinent => "geo_continent",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.GeoCountry => "geo_country",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.GeoCountryRegion => "geo_country_region",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Header => "header",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Host => "host",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.IpAddress => "ip_address",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Ja3Digest => "ja3_digest",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Ja4Digest => "ja4_digest",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Method => "method",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Path => "path",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Protocol => "protocol",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Query => "query",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.RateLimitApiId => "rate_limit_api_id",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.RawPath => "raw_path",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Region => "region",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Route => "route",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.Scheme => "scheme",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.ServerAction => "server_action",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.TargetPath => "target_path",
                PutFirewallConfigRequestRuleConditionGroupItemConditionType.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRuleConditionGroupItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "bot_category" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.BotCategory,
                "bot_name" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.BotName,
                "bot_protection" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.BotProtection,
                "bot_status" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.BotStatus,
                "cookie" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Cookie,
                "environment" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Environment,
                "geo_as_number" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.GeoAsNumber,
                "geo_city" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.GeoCity,
                "geo_continent" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.GeoContinent,
                "geo_country" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.GeoCountry,
                "geo_country_region" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.GeoCountryRegion,
                "header" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Header,
                "host" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Host,
                "ip_address" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.IpAddress,
                "ja3_digest" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Ja3Digest,
                "ja4_digest" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Ja4Digest,
                "method" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Method,
                "path" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Path,
                "protocol" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Protocol,
                "query" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Query,
                "rate_limit_api_id" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.RateLimitApiId,
                "raw_path" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.RawPath,
                "region" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Region,
                "route" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Route,
                "scheme" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.Scheme,
                "server_action" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.ServerAction,
                "target_path" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.TargetPath,
                "user_agent" => PutFirewallConfigRequestRuleConditionGroupItemConditionType.UserAgent,
                _ => null,
            };
        }
    }
}