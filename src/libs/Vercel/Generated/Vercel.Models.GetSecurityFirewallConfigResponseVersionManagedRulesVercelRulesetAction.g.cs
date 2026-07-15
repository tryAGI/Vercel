
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionManagedRulesVercelRulesetAction
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
    public static class GetSecurityFirewallConfigResponseVersionManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionManagedRulesVercelRulesetAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionManagedRulesVercelRulesetAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseVersionManagedRulesVercelRulesetAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionManagedRulesVercelRulesetAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}