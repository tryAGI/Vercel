
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveManagedRulesAiBotsAction
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
    public static class GetSecurityFirewallConfigResponseActiveManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveManagedRulesAiBotsAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveManagedRulesAiBotsAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveManagedRulesAiBotsAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseActiveManagedRulesAiBotsAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveManagedRulesAiBotsAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}