
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant2ActionMitigateAction
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
    public static class GetFirewallConfigResponseRuleVariant2ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant2ActionMitigateAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant2ActionMitigateAction.Bypass => "bypass",
                GetFirewallConfigResponseRuleVariant2ActionMitigateAction.Challenge => "challenge",
                GetFirewallConfigResponseRuleVariant2ActionMitigateAction.Deny => "deny",
                GetFirewallConfigResponseRuleVariant2ActionMitigateAction.Log => "log",
                GetFirewallConfigResponseRuleVariant2ActionMitigateAction.RateLimit => "rate_limit",
                GetFirewallConfigResponseRuleVariant2ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant2ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetFirewallConfigResponseRuleVariant2ActionMitigateAction.Bypass,
                "challenge" => GetFirewallConfigResponseRuleVariant2ActionMitigateAction.Challenge,
                "deny" => GetFirewallConfigResponseRuleVariant2ActionMitigateAction.Deny,
                "log" => GetFirewallConfigResponseRuleVariant2ActionMitigateAction.Log,
                "rate_limit" => GetFirewallConfigResponseRuleVariant2ActionMitigateAction.RateLimit,
                "redirect" => GetFirewallConfigResponseRuleVariant2ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}