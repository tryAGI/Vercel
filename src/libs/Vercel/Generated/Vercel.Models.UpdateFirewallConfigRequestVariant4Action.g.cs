
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant4Action
    {
        /// <summary>
        /// 
        /// </summary>
        RulesRemove,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant4ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant4Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant4Action.RulesRemove => "rules.remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant4Action? ToEnum(string value)
        {
            return value switch
            {
                "rules.remove" => UpdateFirewallConfigRequestVariant4Action.RulesRemove,
                _ => null,
            };
        }
    }
}