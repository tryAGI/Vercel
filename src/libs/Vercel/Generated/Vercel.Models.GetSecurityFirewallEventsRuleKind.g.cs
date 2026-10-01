
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallEventsRuleKind
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallEventsRuleKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallEventsRuleKind value)
        {
            return value switch
            {
                GetSecurityFirewallEventsRuleKind.Custom => "custom",
                GetSecurityFirewallEventsRuleKind.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallEventsRuleKind? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetSecurityFirewallEventsRuleKind.Custom,
                "system" => GetSecurityFirewallEventsRuleKind.System,
                _ => null,
            };
        }
    }
}