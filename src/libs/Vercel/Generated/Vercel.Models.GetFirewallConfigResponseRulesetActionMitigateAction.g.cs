
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetFirewallConfigResponseRulesetActionMitigateAction
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
    public static class GetFirewallConfigResponseRulesetActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRulesetActionMitigateAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseRulesetActionMitigateAction.Allow => "allow",
                GetFirewallConfigResponseRulesetActionMitigateAction.Bypass => "bypass",
                GetFirewallConfigResponseRulesetActionMitigateAction.Challenge => "challenge",
                GetFirewallConfigResponseRulesetActionMitigateAction.Deny => "deny",
                GetFirewallConfigResponseRulesetActionMitigateAction.Log => "log",
                GetFirewallConfigResponseRulesetActionMitigateAction.RateLimit => "rate_limit",
                GetFirewallConfigResponseRulesetActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRulesetActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetFirewallConfigResponseRulesetActionMitigateAction.Allow,
                "bypass" => GetFirewallConfigResponseRulesetActionMitigateAction.Bypass,
                "challenge" => GetFirewallConfigResponseRulesetActionMitigateAction.Challenge,
                "deny" => GetFirewallConfigResponseRulesetActionMitigateAction.Deny,
                "log" => GetFirewallConfigResponseRulesetActionMitigateAction.Log,
                "rate_limit" => GetFirewallConfigResponseRulesetActionMitigateAction.RateLimit,
                "redirect" => GetFirewallConfigResponseRulesetActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}