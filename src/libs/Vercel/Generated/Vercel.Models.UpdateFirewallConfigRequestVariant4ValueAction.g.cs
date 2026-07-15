
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
        Allow,
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
    public static class UpdateFirewallConfigRequestVariant4ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant4ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant4ValueAction.Allow => "allow",
                UpdateFirewallConfigRequestVariant4ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant4ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant4ValueAction.Log => "log",
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
                "allow" => UpdateFirewallConfigRequestVariant4ValueAction.Allow,
                "challenge" => UpdateFirewallConfigRequestVariant4ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant4ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant4ValueAction.Log,
                _ => null,
            };
        }
    }
}