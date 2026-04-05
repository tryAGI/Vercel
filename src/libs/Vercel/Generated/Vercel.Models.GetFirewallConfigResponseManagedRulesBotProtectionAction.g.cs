
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseManagedRulesBotProtectionAction
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
    public static class GetFirewallConfigResponseManagedRulesBotProtectionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseManagedRulesBotProtectionAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseManagedRulesBotProtectionAction.Challenge => "challenge",
                GetFirewallConfigResponseManagedRulesBotProtectionAction.Deny => "deny",
                GetFirewallConfigResponseManagedRulesBotProtectionAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseManagedRulesBotProtectionAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetFirewallConfigResponseManagedRulesBotProtectionAction.Challenge,
                "deny" => GetFirewallConfigResponseManagedRulesBotProtectionAction.Deny,
                "log" => GetFirewallConfigResponseManagedRulesBotProtectionAction.Log,
                _ => null,
            };
        }
    }
}