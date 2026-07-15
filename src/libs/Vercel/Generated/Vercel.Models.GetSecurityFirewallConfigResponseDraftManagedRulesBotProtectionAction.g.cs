
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftManagedRulesBotProtectionAction
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
    public static class GetSecurityFirewallConfigResponseDraftManagedRulesBotProtectionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftManagedRulesBotProtectionAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftManagedRulesBotProtectionAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftManagedRulesBotProtectionAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftManagedRulesBotProtectionAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftManagedRulesBotProtectionAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseDraftManagedRulesBotProtectionAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftManagedRulesBotProtectionAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftManagedRulesBotProtectionAction.Log,
                _ => null,
            };
        }
    }
}