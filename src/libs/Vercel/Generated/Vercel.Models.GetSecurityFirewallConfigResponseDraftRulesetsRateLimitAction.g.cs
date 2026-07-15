
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction
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
    public static class GetSecurityFirewallConfigResponseDraftRulesetsRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction.Log => "log",
                GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseDraftRulesetsRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}