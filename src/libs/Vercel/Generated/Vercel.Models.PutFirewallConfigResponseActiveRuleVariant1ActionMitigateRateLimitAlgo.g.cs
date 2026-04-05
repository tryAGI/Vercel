
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo
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
    public static class PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}