
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRulesetAction
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
    public static class AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRulesetAction.Challenge => "challenge",
                AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRulesetAction.Deny => "deny",
                AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRulesetAction.Challenge,
                "deny" => AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRulesetAction.Deny,
                "log" => AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}