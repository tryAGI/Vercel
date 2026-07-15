
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveManagedRulesVercelRulesetAction
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
    public static class GetSecurityFirewallConfigResponseActiveManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}