
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant7Action
    {
        /// <summary>
        /// 
        /// </summary>
        CrsDisable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant7ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant7Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant7Action.CrsDisable => "crs.disable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant7Action? ToEnum(string value)
        {
            return value switch
            {
                "crs.disable" => UpdateFirewallConfigRequestVariant7Action.CrsDisable,
                _ => null,
            };
        }
    }
}