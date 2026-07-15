
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBotsAction
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBotsAction value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBotsAction.Challenge => "challenge",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBotsAction.Deny => "deny",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBotsAction.Challenge,
                "deny" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBotsAction.Deny,
                "log" => CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}