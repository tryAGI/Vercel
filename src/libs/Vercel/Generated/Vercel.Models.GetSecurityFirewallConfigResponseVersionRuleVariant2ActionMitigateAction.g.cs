
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction
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
    public static class GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Allow => "allow",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Log => "log",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseVersionRuleVariant2ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}