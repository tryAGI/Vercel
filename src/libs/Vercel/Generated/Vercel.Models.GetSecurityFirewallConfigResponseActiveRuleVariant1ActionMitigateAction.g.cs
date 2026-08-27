
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction
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
    public static class GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Allow => "allow",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Log => "log",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.RateLimit => "rate_limit",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Allow,
                "bypass" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Log,
                "rate_limit" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.RateLimit,
                "redirect" => GetSecurityFirewallConfigResponseActiveRuleVariant1ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}