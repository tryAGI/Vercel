
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRulesetsRateLimitAction
    {
        /// <summary>
        /// 
        /// </summary>
        Challenge,
        /// <summary>
        /// 
        /// </summary>
        Deny,
        /// <summary>
        /// 
        /// </summary>
        Log,
        /// <summary>
        /// 
        /// </summary>
        RateLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFirewallConfigResponseRulesetsRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRulesetsRateLimitAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseRulesetsRateLimitAction.Challenge => "challenge",
                GetFirewallConfigResponseRulesetsRateLimitAction.Deny => "deny",
                GetFirewallConfigResponseRulesetsRateLimitAction.Log => "log",
                GetFirewallConfigResponseRulesetsRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRulesetsRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetFirewallConfigResponseRulesetsRateLimitAction.Challenge,
                "deny" => GetFirewallConfigResponseRulesetsRateLimitAction.Deny,
                "log" => GetFirewallConfigResponseRulesetsRateLimitAction.Log,
                "rate_limit" => GetFirewallConfigResponseRulesetsRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}