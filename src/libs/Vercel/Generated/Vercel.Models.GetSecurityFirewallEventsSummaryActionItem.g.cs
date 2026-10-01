
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallEventsSummaryActionItem
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
    public static class GetSecurityFirewallEventsSummaryActionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallEventsSummaryActionItem value)
        {
            return value switch
            {
                GetSecurityFirewallEventsSummaryActionItem.Bypass => "bypass",
                GetSecurityFirewallEventsSummaryActionItem.Challenge => "challenge",
                GetSecurityFirewallEventsSummaryActionItem.Deny => "deny",
                GetSecurityFirewallEventsSummaryActionItem.Log => "log",
                GetSecurityFirewallEventsSummaryActionItem.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallEventsSummaryActionItem? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetSecurityFirewallEventsSummaryActionItem.Bypass,
                "challenge" => GetSecurityFirewallEventsSummaryActionItem.Challenge,
                "deny" => GetSecurityFirewallEventsSummaryActionItem.Deny,
                "log" => GetSecurityFirewallEventsSummaryActionItem.Log,
                "rate_limit" => GetSecurityFirewallEventsSummaryActionItem.RateLimit,
                _ => null,
            };
        }
    }
}