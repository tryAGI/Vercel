
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAlgo
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
    public static class GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}