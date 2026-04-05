
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant6ValueAction
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
    public static class UpdateFirewallConfigRequestVariant6ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant6ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant6ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant6ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant6ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => UpdateFirewallConfigRequestVariant6ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant6ValueAction.Log,
                _ => null,
            };
        }
    }
}