
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant4ValueRateLimitAction
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
    public static class UpdateFirewallConfigRequestVariant4ValueRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant4ValueRateLimitAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant4ValueRateLimitAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant4ValueRateLimitAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant4ValueRateLimitAction.Log => "log",
                UpdateFirewallConfigRequestVariant4ValueRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant4ValueRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant4ValueRateLimitAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant4ValueRateLimitAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant4ValueRateLimitAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant4ValueRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}