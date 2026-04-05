
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant10Action
    {
        /// <summary>
        /// 
        /// </summary>
        IpRemove,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant10ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant10Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant10Action.IpRemove => "ip.remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant10Action? ToEnum(string value)
        {
            return value switch
            {
                "ip.remove" => UpdateFirewallConfigRequestVariant10Action.IpRemove,
                _ => null,
            };
        }
    }
}