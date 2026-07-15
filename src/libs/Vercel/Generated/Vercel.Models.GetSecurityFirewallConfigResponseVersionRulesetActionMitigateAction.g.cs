
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction
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
    public static class GetSecurityFirewallConfigResponseVersionRulesetActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Allow => "allow",
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Log => "log",
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}