
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveManagedRulesAiBotsAction
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
    public static class PutFirewallConfigResponseActiveManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveManagedRulesAiBotsAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveManagedRulesAiBotsAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveManagedRulesAiBotsAction.Deny => "deny",
                PutFirewallConfigResponseActiveManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigResponseActiveManagedRulesAiBotsAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveManagedRulesAiBotsAction.Deny,
                "log" => PutFirewallConfigResponseActiveManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}