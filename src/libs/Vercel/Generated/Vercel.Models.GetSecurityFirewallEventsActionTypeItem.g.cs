
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallEventsActionTypeItem
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
    public static class GetSecurityFirewallEventsActionTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallEventsActionTypeItem value)
        {
            return value switch
            {
                GetSecurityFirewallEventsActionTypeItem.CustomerAction => "customer-action",
                GetSecurityFirewallEventsActionTypeItem.SystemAction => "system-action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallEventsActionTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "customer-action" => GetSecurityFirewallEventsActionTypeItem.CustomerAction,
                "system-action" => GetSecurityFirewallEventsActionTypeItem.SystemAction,
                _ => null,
            };
        }
    }
}