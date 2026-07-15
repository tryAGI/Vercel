
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRulesetsAction
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
    public static class GetFirewallConfigResponseRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRulesetsAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseRulesetsAction.Allow => "allow",
                GetFirewallConfigResponseRulesetsAction.Bypass => "bypass",
                GetFirewallConfigResponseRulesetsAction.Challenge => "challenge",
                GetFirewallConfigResponseRulesetsAction.Deny => "deny",
                GetFirewallConfigResponseRulesetsAction.Log => "log",
                GetFirewallConfigResponseRulesetsAction.RateLimit => "rate_limit",
                GetFirewallConfigResponseRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetFirewallConfigResponseRulesetsAction.Allow,
                "bypass" => GetFirewallConfigResponseRulesetsAction.Bypass,
                "challenge" => GetFirewallConfigResponseRulesetsAction.Challenge,
                "deny" => GetFirewallConfigResponseRulesetsAction.Deny,
                "log" => GetFirewallConfigResponseRulesetsAction.Log,
                "rate_limit" => GetFirewallConfigResponseRulesetsAction.RateLimit,
                "redirect" => GetFirewallConfigResponseRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}