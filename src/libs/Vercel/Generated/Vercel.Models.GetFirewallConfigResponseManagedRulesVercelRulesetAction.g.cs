
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseManagedRulesVercelRulesetAction
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
    public static class GetFirewallConfigResponseManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseManagedRulesVercelRulesetAction.Challenge => "challenge",
                GetFirewallConfigResponseManagedRulesVercelRulesetAction.Deny => "deny",
                GetFirewallConfigResponseManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetFirewallConfigResponseManagedRulesVercelRulesetAction.Challenge,
                "deny" => GetFirewallConfigResponseManagedRulesVercelRulesetAction.Deny,
                "log" => GetFirewallConfigResponseManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}