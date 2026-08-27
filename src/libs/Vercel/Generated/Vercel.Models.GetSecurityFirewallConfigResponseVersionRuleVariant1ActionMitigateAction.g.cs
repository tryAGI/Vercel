
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction
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
    public static class GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Allow => "allow",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Log => "log",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseVersionRuleVariant1ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}