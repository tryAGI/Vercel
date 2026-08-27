
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PutFirewallConfigResponseActiveRulesetActionMitigateAction
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
    public static class PutFirewallConfigResponseActiveRulesetActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRulesetActionMitigateAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRulesetActionMitigateAction.Allow => "allow",
                PutFirewallConfigResponseActiveRulesetActionMitigateAction.Bypass => "bypass",
                PutFirewallConfigResponseActiveRulesetActionMitigateAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveRulesetActionMitigateAction.Deny => "deny",
                PutFirewallConfigResponseActiveRulesetActionMitigateAction.Log => "log",
                PutFirewallConfigResponseActiveRulesetActionMitigateAction.RateLimit => "rate_limit",
                PutFirewallConfigResponseActiveRulesetActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRulesetActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => PutFirewallConfigResponseActiveRulesetActionMitigateAction.Allow,
                "bypass" => PutFirewallConfigResponseActiveRulesetActionMitigateAction.Bypass,
                "challenge" => PutFirewallConfigResponseActiveRulesetActionMitigateAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveRulesetActionMitigateAction.Deny,
                "log" => PutFirewallConfigResponseActiveRulesetActionMitigateAction.Log,
                "rate_limit" => PutFirewallConfigResponseActiveRulesetActionMitigateAction.RateLimit,
                "redirect" => PutFirewallConfigResponseActiveRulesetActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}