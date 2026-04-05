
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant2Action
    {
        /// <summary>
        /// 
        /// </summary>
        RulesInsert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant2Action value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant2Action.RulesInsert => "rules.insert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "rules.insert" => UpdateFirewallConfigRequestVariant2Action.RulesInsert,
                _ => null,
            };
        }
    }
}