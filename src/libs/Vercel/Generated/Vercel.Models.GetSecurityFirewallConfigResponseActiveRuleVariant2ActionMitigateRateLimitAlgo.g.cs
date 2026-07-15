
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo
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
    public static class GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}