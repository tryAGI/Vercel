
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction
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
    public static class GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Allow => "allow",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Log => "log",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseDraftRuleVariant2ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}