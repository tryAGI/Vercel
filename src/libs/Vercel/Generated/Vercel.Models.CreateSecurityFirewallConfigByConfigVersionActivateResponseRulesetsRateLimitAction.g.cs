
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction.Log => "log",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction.Log,
                "rate_limit" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}