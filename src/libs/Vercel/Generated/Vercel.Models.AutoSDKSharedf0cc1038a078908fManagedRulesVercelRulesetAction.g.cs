
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf0cc1038a078908fManagedRulesVercelRulesetAction
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
    public static class AutoSDKSharedf0cc1038a078908fManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf0cc1038a078908fManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                AutoSDKSharedf0cc1038a078908fManagedRulesVercelRulesetAction.Challenge => "challenge",
                AutoSDKSharedf0cc1038a078908fManagedRulesVercelRulesetAction.Deny => "deny",
                AutoSDKSharedf0cc1038a078908fManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf0cc1038a078908fManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedf0cc1038a078908fManagedRulesVercelRulesetAction.Challenge,
                "deny" => AutoSDKSharedf0cc1038a078908fManagedRulesVercelRulesetAction.Deny,
                "log" => AutoSDKSharedf0cc1038a078908fManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}