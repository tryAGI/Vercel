
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRulesetsAction
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
    public static class GetSecurityFirewallConfigResponseVersionRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRulesetsAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRulesetsAction.Allow => "allow",
                GetSecurityFirewallConfigResponseVersionRulesetsAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseVersionRulesetsAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionRulesetsAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionRulesetsAction.Log => "log",
                GetSecurityFirewallConfigResponseVersionRulesetsAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseVersionRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseVersionRulesetsAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseVersionRulesetsAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseVersionRulesetsAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionRulesetsAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionRulesetsAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseVersionRulesetsAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseVersionRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}