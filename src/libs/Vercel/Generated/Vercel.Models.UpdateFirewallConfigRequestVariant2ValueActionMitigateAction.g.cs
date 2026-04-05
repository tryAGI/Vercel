
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant2ValueActionMitigateAction
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
    public static class UpdateFirewallConfigRequestVariant2ValueActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant2ValueActionMitigateAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Log => "log",
                UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.RateLimit => "rate_limit",
                UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant2ValueActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.RateLimit,
                "redirect" => UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}