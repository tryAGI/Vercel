
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallEventsSummaryActionTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        CustomerAction,
        /// <summary>
        ///
        /// </summary>
        SystemAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallEventsSummaryActionTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallEventsSummaryActionTypeItem value)
        {
            return value switch
            {
                GetSecurityFirewallEventsSummaryActionTypeItem.CustomerAction => "customer-action",
                GetSecurityFirewallEventsSummaryActionTypeItem.SystemAction => "system-action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallEventsSummaryActionTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "customer-action" => GetSecurityFirewallEventsSummaryActionTypeItem.CustomerAction,
                "system-action" => GetSecurityFirewallEventsSummaryActionTypeItem.SystemAction,
                _ => null,
            };
        }
    }
}