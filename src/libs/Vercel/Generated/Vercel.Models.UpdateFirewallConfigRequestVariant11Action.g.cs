
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant11Action
    {
        /// <summary>
        /// 
        /// </summary>
        ManagedRulesUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant11ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant11Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant11Action.ManagedRulesUpdate => "managedRules.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant11Action? ToEnum(string value)
        {
            return value switch
            {
                "managedRules.update" => UpdateFirewallConfigRequestVariant11Action.ManagedRulesUpdate,
                _ => null,
            };
        }
    }
}