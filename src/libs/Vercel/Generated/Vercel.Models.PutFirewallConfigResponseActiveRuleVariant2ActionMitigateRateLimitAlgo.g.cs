
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo
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
    public static class PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}