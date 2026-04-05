
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction
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
    public static class PutFirewallConfigResponseActiveRuleVariant2ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Bypass => "bypass",
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Deny => "deny",
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Log => "log",
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.RateLimit => "rate_limit",
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Bypass,
                "challenge" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Deny,
                "log" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Log,
                "rate_limit" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.RateLimit,
                "redirect" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}