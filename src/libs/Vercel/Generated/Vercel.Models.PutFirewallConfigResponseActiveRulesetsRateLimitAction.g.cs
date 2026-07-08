
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRulesetsRateLimitAction
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
    public static class PutFirewallConfigResponseActiveRulesetsRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRulesetsRateLimitAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRulesetsRateLimitAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveRulesetsRateLimitAction.Deny => "deny",
                PutFirewallConfigResponseActiveRulesetsRateLimitAction.Log => "log",
                PutFirewallConfigResponseActiveRulesetsRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRulesetsRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigResponseActiveRulesetsRateLimitAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveRulesetsRateLimitAction.Deny,
                "log" => PutFirewallConfigResponseActiveRulesetsRateLimitAction.Log,
                "rate_limit" => PutFirewallConfigResponseActiveRulesetsRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}