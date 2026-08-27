
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo
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
    public static class GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}