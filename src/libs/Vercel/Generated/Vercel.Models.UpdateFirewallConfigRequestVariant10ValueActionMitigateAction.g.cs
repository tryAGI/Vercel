
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant10ValueActionMitigateAction
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
    public static class UpdateFirewallConfigRequestVariant10ValueActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant10ValueActionMitigateAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.Log => "log",
                UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.RateLimit => "rate_limit",
                UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant10ValueActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.RateLimit,
                "redirect" => UpdateFirewallConfigRequestVariant10ValueActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}