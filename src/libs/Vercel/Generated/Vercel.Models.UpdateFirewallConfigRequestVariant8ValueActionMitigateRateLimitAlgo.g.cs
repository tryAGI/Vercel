
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAlgo
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
    public static class UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => UpdateFirewallConfigRequestVariant8ValueActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}