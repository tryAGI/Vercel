
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant12ValueActionMitigateAction
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
    public static class UpdateFirewallConfigRequestVariant12ValueActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant12ValueActionMitigateAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.Log => "log",
                UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.RateLimit => "rate_limit",
                UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant12ValueActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.RateLimit,
                "redirect" => UpdateFirewallConfigRequestVariant12ValueActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}