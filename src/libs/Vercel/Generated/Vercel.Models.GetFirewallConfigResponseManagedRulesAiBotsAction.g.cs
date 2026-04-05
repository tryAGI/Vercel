
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseManagedRulesAiBotsAction
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
    public static class GetFirewallConfigResponseManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseManagedRulesAiBotsAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseManagedRulesAiBotsAction.Challenge => "challenge",
                GetFirewallConfigResponseManagedRulesAiBotsAction.Deny => "deny",
                GetFirewallConfigResponseManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetFirewallConfigResponseManagedRulesAiBotsAction.Challenge,
                "deny" => GetFirewallConfigResponseManagedRulesAiBotsAction.Deny,
                "log" => GetFirewallConfigResponseManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}