
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAlgo
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
    public static class GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => GetFirewallConfigResponseRuleVariant1ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}