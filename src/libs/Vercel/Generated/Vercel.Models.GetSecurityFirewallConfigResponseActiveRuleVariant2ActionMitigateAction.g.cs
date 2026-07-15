
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
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
    public static class GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Allow => "allow",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Log => "log",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseActiveRuleVariant2ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}