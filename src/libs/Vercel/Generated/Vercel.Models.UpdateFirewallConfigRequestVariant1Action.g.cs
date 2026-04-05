
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant1Action
    {
        /// <summary>
        /// 
        /// </summary>
        FirewallEnabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant1Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant1Action.FirewallEnabled => "firewallEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant1Action? ToEnum(string value)
        {
            return value switch
            {
                "firewallEnabled" => UpdateFirewallConfigRequestVariant1Action.FirewallEnabled,
                _ => null,
            };
        }
    }
}