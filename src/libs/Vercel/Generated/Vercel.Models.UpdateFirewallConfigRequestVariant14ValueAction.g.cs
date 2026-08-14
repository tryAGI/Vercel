
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant14ValueAction
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
    public static class UpdateFirewallConfigRequestVariant14ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant14ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant14ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant14ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant14ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => UpdateFirewallConfigRequestVariant14ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant14ValueAction.Log,
                _ => null,
            };
        }
    }
}