
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant4ValueAction
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
    public static class UpdateFirewallConfigRequestVariant4ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant4ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant4ValueAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant4ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant4ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant4ValueAction.Log => "log",
                UpdateFirewallConfigRequestVariant4ValueAction.RateLimit => "rate_limit",
                UpdateFirewallConfigRequestVariant4ValueAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant4ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant4ValueAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant4ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant4ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant4ValueAction.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant4ValueAction.RateLimit,
                "redirect" => UpdateFirewallConfigRequestVariant4ValueAction.Redirect,
                _ => null,
            };
        }
    }
}