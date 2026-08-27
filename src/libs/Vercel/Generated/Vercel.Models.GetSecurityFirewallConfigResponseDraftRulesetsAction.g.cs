
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRulesetsAction
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
    public static class GetSecurityFirewallConfigResponseDraftRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRulesetsAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRulesetsAction.Allow => "allow",
                GetSecurityFirewallConfigResponseDraftRulesetsAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseDraftRulesetsAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftRulesetsAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftRulesetsAction.Log => "log",
                GetSecurityFirewallConfigResponseDraftRulesetsAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseDraftRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseDraftRulesetsAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseDraftRulesetsAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseDraftRulesetsAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftRulesetsAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftRulesetsAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseDraftRulesetsAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseDraftRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}