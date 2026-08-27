
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionManagedRulesAiBotsAction
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
    public static class GetSecurityFirewallConfigResponseVersionManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionManagedRulesAiBotsAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionManagedRulesAiBotsAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionManagedRulesAiBotsAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseVersionManagedRulesAiBotsAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionManagedRulesAiBotsAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}