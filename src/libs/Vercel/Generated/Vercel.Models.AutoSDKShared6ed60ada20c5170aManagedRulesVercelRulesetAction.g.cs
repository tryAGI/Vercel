
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed60ada20c5170aManagedRulesVercelRulesetAction
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
    public static class AutoSDKShared6ed60ada20c5170aManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed60ada20c5170aManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                AutoSDKShared6ed60ada20c5170aManagedRulesVercelRulesetAction.Challenge => "challenge",
                AutoSDKShared6ed60ada20c5170aManagedRulesVercelRulesetAction.Deny => "deny",
                AutoSDKShared6ed60ada20c5170aManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed60ada20c5170aManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared6ed60ada20c5170aManagedRulesVercelRulesetAction.Challenge,
                "deny" => AutoSDKShared6ed60ada20c5170aManagedRulesVercelRulesetAction.Deny,
                "log" => AutoSDKShared6ed60ada20c5170aManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}