
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAlgo
    {
        /// <summary>
        ///
        /// </summary>
        FixedWindow,
        /// <summary>
        ///
        /// </summary>
        TokenBucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => UpdateFirewallConfigRequestVariant12ValueActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}