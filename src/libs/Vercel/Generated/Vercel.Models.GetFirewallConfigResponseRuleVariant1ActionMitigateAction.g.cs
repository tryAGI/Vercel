
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant1ActionMitigateAction
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
    public static class GetFirewallConfigResponseRuleVariant1ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant1ActionMitigateAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant1ActionMitigateAction.Bypass => "bypass",
                GetFirewallConfigResponseRuleVariant1ActionMitigateAction.Challenge => "challenge",
                GetFirewallConfigResponseRuleVariant1ActionMitigateAction.Deny => "deny",
                GetFirewallConfigResponseRuleVariant1ActionMitigateAction.Log => "log",
                GetFirewallConfigResponseRuleVariant1ActionMitigateAction.RateLimit => "rate_limit",
                GetFirewallConfigResponseRuleVariant1ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant1ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetFirewallConfigResponseRuleVariant1ActionMitigateAction.Bypass,
                "challenge" => GetFirewallConfigResponseRuleVariant1ActionMitigateAction.Challenge,
                "deny" => GetFirewallConfigResponseRuleVariant1ActionMitigateAction.Deny,
                "log" => GetFirewallConfigResponseRuleVariant1ActionMitigateAction.Log,
                "rate_limit" => GetFirewallConfigResponseRuleVariant1ActionMitigateAction.RateLimit,
                "redirect" => GetFirewallConfigResponseRuleVariant1ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}