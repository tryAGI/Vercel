
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionManagedRulesTrafficSourcesAction
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
    public static class GetSecurityFirewallConfigResponseVersionManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionManagedRulesTrafficSourcesAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionManagedRulesTrafficSourcesAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseVersionManagedRulesTrafficSourcesAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionManagedRulesTrafficSourcesAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}