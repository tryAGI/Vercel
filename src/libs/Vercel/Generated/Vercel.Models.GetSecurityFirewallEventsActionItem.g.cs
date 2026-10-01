
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallEventsActionItem
    {
        /// <summary>
        ///
        /// </summary>
        Bypass,
        /// <summary>
        ///
        /// </summary>
        Challenge,
        /// <summary>
        ///
        /// </summary>
        Deny,
        /// <summary>
        ///
        /// </summary>
        Log,
        /// <summary>
        ///
        /// </summary>
        RateLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallEventsActionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallEventsActionItem value)
        {
            return value switch
            {
                GetSecurityFirewallEventsActionItem.Bypass => "bypass",
                GetSecurityFirewallEventsActionItem.Challenge => "challenge",
                GetSecurityFirewallEventsActionItem.Deny => "deny",
                GetSecurityFirewallEventsActionItem.Log => "log",
                GetSecurityFirewallEventsActionItem.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallEventsActionItem? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetSecurityFirewallEventsActionItem.Bypass,
                "challenge" => GetSecurityFirewallEventsActionItem.Challenge,
                "deny" => GetSecurityFirewallEventsActionItem.Deny,
                "log" => GetSecurityFirewallEventsActionItem.Log,
                "rate_limit" => GetSecurityFirewallEventsActionItem.RateLimit,
                _ => null,
            };
        }
    }
}