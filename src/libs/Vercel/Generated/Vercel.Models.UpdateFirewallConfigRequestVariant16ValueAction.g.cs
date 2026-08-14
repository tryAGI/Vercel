
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant16ValueAction
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
    public static class UpdateFirewallConfigRequestVariant16ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant16ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant16ValueAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant16ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant16ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant16ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant16ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant16ValueAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant16ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant16ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant16ValueAction.Log,
                _ => null,
            };
        }
    }
}