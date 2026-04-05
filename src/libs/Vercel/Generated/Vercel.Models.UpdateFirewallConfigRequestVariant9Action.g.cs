
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant9Action
    {
        /// <summary>
        /// 
        /// </summary>
        IpUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant9ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant9Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant9Action.IpUpdate => "ip.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant9Action? ToEnum(string value)
        {
            return value switch
            {
                "ip.update" => UpdateFirewallConfigRequestVariant9Action.IpUpdate,
                _ => null,
            };
        }
    }
}