
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction
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
    public static class GetSecurityFirewallConfigResponseDraftRulesetActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Allow => "allow",
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Log => "log",
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseDraftRulesetActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}