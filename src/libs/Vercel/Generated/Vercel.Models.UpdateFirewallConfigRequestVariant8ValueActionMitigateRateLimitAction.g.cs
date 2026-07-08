
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction
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
    public static class UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction.Log => "log",
                UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}