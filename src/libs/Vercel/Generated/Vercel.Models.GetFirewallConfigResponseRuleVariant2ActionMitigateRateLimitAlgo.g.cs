
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAlgo
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
    public static class GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => GetFirewallConfigResponseRuleVariant2ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}