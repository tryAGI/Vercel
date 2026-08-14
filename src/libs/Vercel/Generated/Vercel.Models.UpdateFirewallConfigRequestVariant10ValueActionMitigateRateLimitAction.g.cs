
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction
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
    public static class UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction.Log => "log",
                UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}