
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction
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
    public static class UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction.Log => "log",
                UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant11ValueActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}