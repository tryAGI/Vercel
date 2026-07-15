
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction
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
    public static class GetSecurityFirewallConfigResponseActiveRulesetActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Allow => "allow",
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Log => "log",
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseActiveRulesetActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}