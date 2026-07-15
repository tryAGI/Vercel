
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAlgo
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
    public static class GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}