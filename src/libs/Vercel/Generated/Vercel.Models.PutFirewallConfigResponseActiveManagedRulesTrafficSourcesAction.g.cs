
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PutFirewallConfigResponseActiveManagedRulesTrafficSourcesAction
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
    public static class PutFirewallConfigResponseActiveManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Deny => "deny",
                PutFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Deny,
                "log" => PutFirewallConfigResponseActiveManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}