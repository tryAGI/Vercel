
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant8ValueActionMitigateAction
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
    public static class UpdateFirewallConfigRequestVariant8ValueActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant8ValueActionMitigateAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.Log => "log",
                UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.RateLimit => "rate_limit",
                UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant8ValueActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.RateLimit,
                "redirect" => UpdateFirewallConfigRequestVariant8ValueActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}