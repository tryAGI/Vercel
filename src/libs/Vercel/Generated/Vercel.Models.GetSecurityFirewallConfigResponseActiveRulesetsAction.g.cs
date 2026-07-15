
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRulesetsAction
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
    public static class GetSecurityFirewallConfigResponseActiveRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRulesetsAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRulesetsAction.Allow => "allow",
                GetSecurityFirewallConfigResponseActiveRulesetsAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseActiveRulesetsAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveRulesetsAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveRulesetsAction.Log => "log",
                GetSecurityFirewallConfigResponseActiveRulesetsAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseActiveRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseActiveRulesetsAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseActiveRulesetsAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseActiveRulesetsAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveRulesetsAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveRulesetsAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseActiveRulesetsAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseActiveRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}