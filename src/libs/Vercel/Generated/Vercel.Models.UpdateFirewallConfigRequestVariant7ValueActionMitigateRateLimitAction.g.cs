
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction
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
    public static class UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction.Log => "log",
                UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}