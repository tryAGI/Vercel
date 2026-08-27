
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSourcesAction
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
    public static class GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSourcesAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSourcesAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSourcesAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSourcesAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}