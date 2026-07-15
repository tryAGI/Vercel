
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftManagedRulesAiBotsAction
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
    public static class GetSecurityFirewallConfigResponseDraftManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftManagedRulesAiBotsAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftManagedRulesAiBotsAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftManagedRulesAiBotsAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseDraftManagedRulesAiBotsAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftManagedRulesAiBotsAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}