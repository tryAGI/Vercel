
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1ed2975831fbb888ManagedRulesVercelRulesetAction
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
    public static class AutoSDKShared1ed2975831fbb888ManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1ed2975831fbb888ManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                AutoSDKShared1ed2975831fbb888ManagedRulesVercelRulesetAction.Challenge => "challenge",
                AutoSDKShared1ed2975831fbb888ManagedRulesVercelRulesetAction.Deny => "deny",
                AutoSDKShared1ed2975831fbb888ManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1ed2975831fbb888ManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared1ed2975831fbb888ManagedRulesVercelRulesetAction.Challenge,
                "deny" => AutoSDKShared1ed2975831fbb888ManagedRulesVercelRulesetAction.Deny,
                "log" => AutoSDKShared1ed2975831fbb888ManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}