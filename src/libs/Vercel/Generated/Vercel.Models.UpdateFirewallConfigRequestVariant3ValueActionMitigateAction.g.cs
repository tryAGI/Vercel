
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant3ValueActionMitigateAction
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
    public static class UpdateFirewallConfigRequestVariant3ValueActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant3ValueActionMitigateAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.Log => "log",
                UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.RateLimit => "rate_limit",
                UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant3ValueActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.RateLimit,
                "redirect" => UpdateFirewallConfigRequestVariant3ValueActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}