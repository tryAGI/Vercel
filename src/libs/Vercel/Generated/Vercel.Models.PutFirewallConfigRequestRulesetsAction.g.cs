
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestRulesetsAction
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
    public static class PutFirewallConfigRequestRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRulesetsAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestRulesetsAction.Bypass => "bypass",
                PutFirewallConfigRequestRulesetsAction.Challenge => "challenge",
                PutFirewallConfigRequestRulesetsAction.Deny => "deny",
                PutFirewallConfigRequestRulesetsAction.Log => "log",
                PutFirewallConfigRequestRulesetsAction.RateLimit => "rate_limit",
                PutFirewallConfigRequestRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => PutFirewallConfigRequestRulesetsAction.Bypass,
                "challenge" => PutFirewallConfigRequestRulesetsAction.Challenge,
                "deny" => PutFirewallConfigRequestRulesetsAction.Deny,
                "log" => PutFirewallConfigRequestRulesetsAction.Log,
                "rate_limit" => PutFirewallConfigRequestRulesetsAction.RateLimit,
                "redirect" => PutFirewallConfigRequestRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}