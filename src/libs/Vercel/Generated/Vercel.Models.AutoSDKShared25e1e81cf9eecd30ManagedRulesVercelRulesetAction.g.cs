
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared25e1e81cf9eecd30ManagedRulesVercelRulesetAction
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
    public static class AutoSDKShared25e1e81cf9eecd30ManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared25e1e81cf9eecd30ManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                AutoSDKShared25e1e81cf9eecd30ManagedRulesVercelRulesetAction.Challenge => "challenge",
                AutoSDKShared25e1e81cf9eecd30ManagedRulesVercelRulesetAction.Deny => "deny",
                AutoSDKShared25e1e81cf9eecd30ManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared25e1e81cf9eecd30ManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared25e1e81cf9eecd30ManagedRulesVercelRulesetAction.Challenge,
                "deny" => AutoSDKShared25e1e81cf9eecd30ManagedRulesVercelRulesetAction.Deny,
                "log" => AutoSDKShared25e1e81cf9eecd30ManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}