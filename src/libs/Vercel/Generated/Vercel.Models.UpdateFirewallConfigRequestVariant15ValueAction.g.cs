
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant15ValueAction
    {
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
    public static class UpdateFirewallConfigRequestVariant15ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant15ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant15ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant15ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant15ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => UpdateFirewallConfigRequestVariant15ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant15ValueAction.Log,
                _ => null,
            };
        }
    }
}