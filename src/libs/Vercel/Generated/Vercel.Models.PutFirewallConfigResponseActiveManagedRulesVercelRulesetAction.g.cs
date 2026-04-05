
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveManagedRulesVercelRulesetAction
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
    public static class PutFirewallConfigResponseActiveManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Deny => "deny",
                PutFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Deny,
                "log" => PutFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}