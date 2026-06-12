
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseManagedRulesTrafficSourcesAction
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
    public static class GetFirewallConfigResponseManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseManagedRulesTrafficSourcesAction.Challenge => "challenge",
                GetFirewallConfigResponseManagedRulesTrafficSourcesAction.Deny => "deny",
                GetFirewallConfigResponseManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetFirewallConfigResponseManagedRulesTrafficSourcesAction.Challenge,
                "deny" => GetFirewallConfigResponseManagedRulesTrafficSourcesAction.Deny,
                "log" => GetFirewallConfigResponseManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}