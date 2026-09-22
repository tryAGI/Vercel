
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3770e4df73b880dManagedRulesVercelRulesetAction
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
    public static class AutoSDKShareda3770e4df73b880dManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3770e4df73b880dManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                AutoSDKShareda3770e4df73b880dManagedRulesVercelRulesetAction.Challenge => "challenge",
                AutoSDKShareda3770e4df73b880dManagedRulesVercelRulesetAction.Deny => "deny",
                AutoSDKShareda3770e4df73b880dManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3770e4df73b880dManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShareda3770e4df73b880dManagedRulesVercelRulesetAction.Challenge,
                "deny" => AutoSDKShareda3770e4df73b880dManagedRulesVercelRulesetAction.Deny,
                "log" => AutoSDKShareda3770e4df73b880dManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}