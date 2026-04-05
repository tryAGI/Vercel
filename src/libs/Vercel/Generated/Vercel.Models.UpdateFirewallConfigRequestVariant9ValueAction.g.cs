
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant9ValueAction
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
    public static class UpdateFirewallConfigRequestVariant9ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant9ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant9ValueAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant9ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant9ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant9ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant9ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant9ValueAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant9ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant9ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant9ValueAction.Log,
                _ => null,
            };
        }
    }
}