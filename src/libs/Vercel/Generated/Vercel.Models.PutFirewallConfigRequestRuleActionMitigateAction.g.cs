
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestRuleActionMitigateAction
    {
        /// <summary>
        /// 
        /// </summary>
        Bypass,
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
        /// <summary>
        /// 
        /// </summary>
        Redirect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutFirewallConfigRequestRuleActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRuleActionMitigateAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestRuleActionMitigateAction.Bypass => "bypass",
                PutFirewallConfigRequestRuleActionMitigateAction.Challenge => "challenge",
                PutFirewallConfigRequestRuleActionMitigateAction.Deny => "deny",
                PutFirewallConfigRequestRuleActionMitigateAction.Log => "log",
                PutFirewallConfigRequestRuleActionMitigateAction.RateLimit => "rate_limit",
                PutFirewallConfigRequestRuleActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRuleActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => PutFirewallConfigRequestRuleActionMitigateAction.Bypass,
                "challenge" => PutFirewallConfigRequestRuleActionMitigateAction.Challenge,
                "deny" => PutFirewallConfigRequestRuleActionMitigateAction.Deny,
                "log" => PutFirewallConfigRequestRuleActionMitigateAction.Log,
                "rate_limit" => PutFirewallConfigRequestRuleActionMitigateAction.RateLimit,
                "redirect" => PutFirewallConfigRequestRuleActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}