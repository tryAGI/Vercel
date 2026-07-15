
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionManagedRulesBotProtectionAction
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
    public static class GetSecurityFirewallConfigResponseVersionManagedRulesBotProtectionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionManagedRulesBotProtectionAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionManagedRulesBotProtectionAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionManagedRulesBotProtectionAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionManagedRulesBotProtectionAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionManagedRulesBotProtectionAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseVersionManagedRulesBotProtectionAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionManagedRulesBotProtectionAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionManagedRulesBotProtectionAction.Log,
                _ => null,
            };
        }
    }
}