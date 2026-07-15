
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction
    {
        /// <summary>
        /// 
        /// </summary>
        Challenge,
        /// <summary>
        /// 
        /// </summary>
        Deny,
        /// <summary>
        /// 
        /// </summary>
        Log,
        /// <summary>
        /// 
        /// </summary>
        RateLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction.Log => "log",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction.Log,
                "rate_limit" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}