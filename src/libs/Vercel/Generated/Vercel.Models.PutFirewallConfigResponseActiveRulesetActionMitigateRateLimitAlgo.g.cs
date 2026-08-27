
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo
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
    public static class PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => PutFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}