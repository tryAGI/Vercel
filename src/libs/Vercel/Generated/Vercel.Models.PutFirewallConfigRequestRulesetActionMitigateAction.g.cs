
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestRulesetActionMitigateAction
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
    public static class PutFirewallConfigRequestRulesetActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRulesetActionMitigateAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestRulesetActionMitigateAction.Challenge => "challenge",
                PutFirewallConfigRequestRulesetActionMitigateAction.Deny => "deny",
                PutFirewallConfigRequestRulesetActionMitigateAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRulesetActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigRequestRulesetActionMitigateAction.Challenge,
                "deny" => PutFirewallConfigRequestRulesetActionMitigateAction.Deny,
                "log" => PutFirewallConfigRequestRulesetActionMitigateAction.Log,
                _ => null,
            };
        }
    }
}