
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1Algo
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
    public static class UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1AlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1Algo value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1Algo.FixedWindow => "fixed_window",
                UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1Algo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1Algo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1Algo.FixedWindow,
                "token_bucket" => UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1Algo.TokenBucket,
                _ => null,
            };
        }
    }
}