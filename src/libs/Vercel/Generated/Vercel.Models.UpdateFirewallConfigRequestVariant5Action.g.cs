
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant5Action
    {
        /// <summary>
        /// 
        /// </summary>
        RulesPriority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant5ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant5Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant5Action.RulesPriority => "rules.priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant5Action? ToEnum(string value)
        {
            return value switch
            {
                "rules.priority" => UpdateFirewallConfigRequestVariant5Action.RulesPriority,
                _ => null,
            };
        }
    }
}