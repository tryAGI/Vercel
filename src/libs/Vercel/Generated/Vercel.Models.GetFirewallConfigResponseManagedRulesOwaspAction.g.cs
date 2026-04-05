
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseManagedRulesOwaspAction
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
    public static class GetFirewallConfigResponseManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseManagedRulesOwaspAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseManagedRulesOwaspAction.Challenge => "challenge",
                GetFirewallConfigResponseManagedRulesOwaspAction.Deny => "deny",
                GetFirewallConfigResponseManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetFirewallConfigResponseManagedRulesOwaspAction.Challenge,
                "deny" => GetFirewallConfigResponseManagedRulesOwaspAction.Deny,
                "log" => GetFirewallConfigResponseManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}