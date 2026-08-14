
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant11ValueActionMitigateAction
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
    public static class UpdateFirewallConfigRequestVariant11ValueActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant11ValueActionMitigateAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.Log => "log",
                UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.RateLimit => "rate_limit",
                UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant11ValueActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.RateLimit,
                "redirect" => UpdateFirewallConfigRequestVariant11ValueActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}