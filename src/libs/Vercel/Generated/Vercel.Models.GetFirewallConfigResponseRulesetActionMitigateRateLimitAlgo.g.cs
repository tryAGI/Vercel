
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetFirewallConfigResponseRulesetActionMitigateRateLimitAlgo
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
    public static class GetFirewallConfigResponseRulesetActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRulesetActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                GetFirewallConfigResponseRulesetActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                GetFirewallConfigResponseRulesetActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRulesetActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetFirewallConfigResponseRulesetActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => GetFirewallConfigResponseRulesetActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}