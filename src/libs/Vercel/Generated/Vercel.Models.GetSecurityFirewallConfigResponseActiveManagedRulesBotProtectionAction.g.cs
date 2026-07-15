
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveManagedRulesBotProtectionAction
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
    public static class GetSecurityFirewallConfigResponseActiveManagedRulesBotProtectionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveManagedRulesBotProtectionAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveManagedRulesBotProtectionAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveManagedRulesBotProtectionAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveManagedRulesBotProtectionAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveManagedRulesBotProtectionAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseActiveManagedRulesBotProtectionAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveManagedRulesBotProtectionAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveManagedRulesBotProtectionAction.Log,
                _ => null,
            };
        }
    }
}