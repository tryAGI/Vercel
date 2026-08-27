
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveManagedRulesTrafficSourcesAction
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
    public static class GetSecurityFirewallConfigResponseActiveManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}