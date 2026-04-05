
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1Algo
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
    public static class PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1AlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1Algo value)
        {
            return value switch
            {
                PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1Algo.FixedWindow => "fixed_window",
                PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1Algo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1Algo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1Algo.FixedWindow,
                "token_bucket" => PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1Algo.TokenBucket,
                _ => null,
            };
        }
    }
}