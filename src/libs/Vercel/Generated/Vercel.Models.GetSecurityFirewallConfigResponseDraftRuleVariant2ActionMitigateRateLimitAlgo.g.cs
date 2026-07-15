
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAlgo
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
    public static class GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}