
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant4ValueRateLimitAlgo
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
    public static class UpdateFirewallConfigRequestVariant4ValueRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant4ValueRateLimitAlgo value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant4ValueRateLimitAlgo.FixedWindow => "fixed_window",
                UpdateFirewallConfigRequestVariant4ValueRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant4ValueRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => UpdateFirewallConfigRequestVariant4ValueRateLimitAlgo.FixedWindow,
                "token_bucket" => UpdateFirewallConfigRequestVariant4ValueRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}