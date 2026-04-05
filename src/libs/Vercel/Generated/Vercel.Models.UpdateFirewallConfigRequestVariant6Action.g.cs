
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant6Action
    {
        /// <summary>
        /// 
        /// </summary>
        CrsUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant6ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant6Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant6Action.CrsUpdate => "crs.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant6Action? ToEnum(string value)
        {
            return value switch
            {
                "crs.update" => UpdateFirewallConfigRequestVariant6Action.CrsUpdate,
                _ => null,
            };
        }
    }
}