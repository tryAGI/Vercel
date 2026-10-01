
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallEventsSummaryRuleKind
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
    public static class GetSecurityFirewallEventsSummaryRuleKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallEventsSummaryRuleKind value)
        {
            return value switch
            {
                GetSecurityFirewallEventsSummaryRuleKind.Custom => "custom",
                GetSecurityFirewallEventsSummaryRuleKind.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallEventsSummaryRuleKind? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetSecurityFirewallEventsSummaryRuleKind.Custom,
                "system" => GetSecurityFirewallEventsSummaryRuleKind.System,
                _ => null,
            };
        }
    }
}