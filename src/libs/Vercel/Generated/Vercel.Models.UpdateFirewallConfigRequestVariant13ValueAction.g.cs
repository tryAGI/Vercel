
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant13ValueAction
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant13ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant13ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant13ValueAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant13ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant13ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant13ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant13ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant13ValueAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant13ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant13ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant13ValueAction.Log,
                _ => null,
            };
        }
    }
}