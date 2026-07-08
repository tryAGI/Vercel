
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAlgo
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
    public static class UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => UpdateFirewallConfigRequestVariant7ValueActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}