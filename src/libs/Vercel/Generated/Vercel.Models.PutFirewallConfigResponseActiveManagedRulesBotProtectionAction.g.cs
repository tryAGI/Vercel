
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveManagedRulesBotProtectionAction
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
    public static class PutFirewallConfigResponseActiveManagedRulesBotProtectionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveManagedRulesBotProtectionAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveManagedRulesBotProtectionAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveManagedRulesBotProtectionAction.Deny => "deny",
                PutFirewallConfigResponseActiveManagedRulesBotProtectionAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveManagedRulesBotProtectionAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigResponseActiveManagedRulesBotProtectionAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveManagedRulesBotProtectionAction.Deny,
                "log" => PutFirewallConfigResponseActiveManagedRulesBotProtectionAction.Log,
                _ => null,
            };
        }
    }
}