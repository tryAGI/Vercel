
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant8ValueAction
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
    public static class UpdateFirewallConfigRequestVariant8ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant8ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant8ValueAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant8ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant8ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant8ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant8ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant8ValueAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant8ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant8ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant8ValueAction.Log,
                _ => null,
            };
        }
    }
}