
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction
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
    public static class GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Allow => "allow",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Log => "log",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseDraftRuleVariant1ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}