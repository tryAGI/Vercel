
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveManagedRulesOwaspAction
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
    public static class PutFirewallConfigResponseActiveManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveManagedRulesOwaspAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveManagedRulesOwaspAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveManagedRulesOwaspAction.Deny => "deny",
                PutFirewallConfigResponseActiveManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigResponseActiveManagedRulesOwaspAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveManagedRulesOwaspAction.Deny,
                "log" => PutFirewallConfigResponseActiveManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}