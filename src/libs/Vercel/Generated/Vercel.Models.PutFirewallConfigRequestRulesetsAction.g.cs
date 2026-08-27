
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PutFirewallConfigRequestRulesetsAction
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
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
    public static class PutFirewallConfigRequestRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRulesetsAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestRulesetsAction.Allow => "allow",
                PutFirewallConfigRequestRulesetsAction.Challenge => "challenge",
                PutFirewallConfigRequestRulesetsAction.Deny => "deny",
                PutFirewallConfigRequestRulesetsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => PutFirewallConfigRequestRulesetsAction.Allow,
                "challenge" => PutFirewallConfigRequestRulesetsAction.Challenge,
                "deny" => PutFirewallConfigRequestRulesetsAction.Deny,
                "log" => PutFirewallConfigRequestRulesetsAction.Log,
                _ => null,
            };
        }
    }
}