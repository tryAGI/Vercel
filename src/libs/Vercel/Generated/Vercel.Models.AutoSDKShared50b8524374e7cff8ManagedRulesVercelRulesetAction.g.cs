
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared50b8524374e7cff8ManagedRulesVercelRulesetAction
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
    public static class AutoSDKShared50b8524374e7cff8ManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared50b8524374e7cff8ManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                AutoSDKShared50b8524374e7cff8ManagedRulesVercelRulesetAction.Challenge => "challenge",
                AutoSDKShared50b8524374e7cff8ManagedRulesVercelRulesetAction.Deny => "deny",
                AutoSDKShared50b8524374e7cff8ManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared50b8524374e7cff8ManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared50b8524374e7cff8ManagedRulesVercelRulesetAction.Challenge,
                "deny" => AutoSDKShared50b8524374e7cff8ManagedRulesVercelRulesetAction.Deny,
                "log" => AutoSDKShared50b8524374e7cff8ManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}