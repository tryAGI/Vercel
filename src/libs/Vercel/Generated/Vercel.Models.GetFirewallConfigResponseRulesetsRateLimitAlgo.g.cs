
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetFirewallConfigResponseRulesetsRateLimitAlgo
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
    public static class GetFirewallConfigResponseRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                GetFirewallConfigResponseRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                GetFirewallConfigResponseRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetFirewallConfigResponseRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => GetFirewallConfigResponseRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}