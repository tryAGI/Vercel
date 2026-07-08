
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestRulesetsRateLimitAction
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
    public static class PutFirewallConfigRequestRulesetsRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRulesetsRateLimitAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestRulesetsRateLimitAction.Challenge => "challenge",
                PutFirewallConfigRequestRulesetsRateLimitAction.Deny => "deny",
                PutFirewallConfigRequestRulesetsRateLimitAction.Log => "log",
                PutFirewallConfigRequestRulesetsRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRulesetsRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigRequestRulesetsRateLimitAction.Challenge,
                "deny" => PutFirewallConfigRequestRulesetsRateLimitAction.Deny,
                "log" => PutFirewallConfigRequestRulesetsRateLimitAction.Log,
                "rate_limit" => PutFirewallConfigRequestRulesetsRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}