
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionManagedRulesOwaspAction
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
    public static class GetSecurityFirewallConfigResponseVersionManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionManagedRulesOwaspAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionManagedRulesOwaspAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionManagedRulesOwaspAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseVersionManagedRulesOwaspAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionManagedRulesOwaspAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}