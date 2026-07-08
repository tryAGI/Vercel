
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant7ValueActionMitigateAction
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
    public static class UpdateFirewallConfigRequestVariant7ValueActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant7ValueActionMitigateAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.Log => "log",
                UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.RateLimit => "rate_limit",
                UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant7ValueActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.RateLimit,
                "redirect" => UpdateFirewallConfigRequestVariant7ValueActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}