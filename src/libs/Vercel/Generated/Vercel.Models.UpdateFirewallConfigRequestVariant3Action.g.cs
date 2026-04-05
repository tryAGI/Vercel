
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant3Action
    {
        /// <summary>
        /// 
        /// </summary>
        RulesUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant3ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant3Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant3Action.RulesUpdate => "rules.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant3Action? ToEnum(string value)
        {
            return value switch
            {
                "rules.update" => UpdateFirewallConfigRequestVariant3Action.RulesUpdate,
                _ => null,
            };
        }
    }
}