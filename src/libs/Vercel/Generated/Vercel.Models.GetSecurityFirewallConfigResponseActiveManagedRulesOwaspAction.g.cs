
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveManagedRulesOwaspAction
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallConfigResponseActiveManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveManagedRulesOwaspAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveManagedRulesOwaspAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveManagedRulesOwaspAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseActiveManagedRulesOwaspAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveManagedRulesOwaspAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}