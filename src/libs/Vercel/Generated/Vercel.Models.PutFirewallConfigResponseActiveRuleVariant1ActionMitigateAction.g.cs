
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction
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
    public static class PutFirewallConfigResponseActiveRuleVariant1ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Bypass => "bypass",
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Deny => "deny",
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Log => "log",
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.RateLimit => "rate_limit",
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Bypass,
                "challenge" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Deny,
                "log" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Log,
                "rate_limit" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.RateLimit,
                "redirect" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}