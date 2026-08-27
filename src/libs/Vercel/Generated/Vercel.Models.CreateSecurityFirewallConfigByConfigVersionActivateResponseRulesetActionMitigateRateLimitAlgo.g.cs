
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAlgo
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}