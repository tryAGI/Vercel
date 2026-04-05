
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant8Action
    {
        /// <summary>
        /// 
        /// </summary>
        IpInsert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant8ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant8Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant8Action.IpInsert => "ip.insert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant8Action? ToEnum(string value)
        {
            return value switch
            {
                "ip.insert" => UpdateFirewallConfigRequestVariant8Action.IpInsert,
                _ => null,
            };
        }
    }
}