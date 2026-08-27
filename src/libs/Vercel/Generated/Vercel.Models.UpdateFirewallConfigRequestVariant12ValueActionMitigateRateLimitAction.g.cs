
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction
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
    public static class UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction.Log => "log",
                UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}