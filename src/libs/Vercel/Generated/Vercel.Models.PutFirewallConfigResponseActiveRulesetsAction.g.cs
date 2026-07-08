
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRulesetsAction
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
    public static class PutFirewallConfigResponseActiveRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRulesetsAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRulesetsAction.Bypass => "bypass",
                PutFirewallConfigResponseActiveRulesetsAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveRulesetsAction.Deny => "deny",
                PutFirewallConfigResponseActiveRulesetsAction.Log => "log",
                PutFirewallConfigResponseActiveRulesetsAction.RateLimit => "rate_limit",
                PutFirewallConfigResponseActiveRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => PutFirewallConfigResponseActiveRulesetsAction.Bypass,
                "challenge" => PutFirewallConfigResponseActiveRulesetsAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveRulesetsAction.Deny,
                "log" => PutFirewallConfigResponseActiveRulesetsAction.Log,
                "rate_limit" => PutFirewallConfigResponseActiveRulesetsAction.RateLimit,
                "redirect" => PutFirewallConfigResponseActiveRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}