
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftManagedRulesVercelRulesetAction
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
    public static class GetSecurityFirewallConfigResponseDraftManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftManagedRulesVercelRulesetAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftManagedRulesVercelRulesetAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseDraftManagedRulesVercelRulesetAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftManagedRulesVercelRulesetAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}