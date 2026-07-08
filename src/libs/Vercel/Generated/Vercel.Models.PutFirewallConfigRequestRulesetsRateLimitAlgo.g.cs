
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestRulesetsRateLimitAlgo
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
    public static class PutFirewallConfigRequestRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                PutFirewallConfigRequestRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                PutFirewallConfigRequestRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => PutFirewallConfigRequestRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => PutFirewallConfigRequestRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}