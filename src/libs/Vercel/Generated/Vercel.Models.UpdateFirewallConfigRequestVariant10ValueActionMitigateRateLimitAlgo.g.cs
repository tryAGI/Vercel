
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAlgo
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
    public static class UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => UpdateFirewallConfigRequestVariant10ValueActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}