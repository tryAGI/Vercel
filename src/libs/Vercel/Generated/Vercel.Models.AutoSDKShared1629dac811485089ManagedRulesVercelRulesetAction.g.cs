
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1629dac811485089ManagedRulesVercelRulesetAction
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
    public static class AutoSDKShared1629dac811485089ManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1629dac811485089ManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                AutoSDKShared1629dac811485089ManagedRulesVercelRulesetAction.Challenge => "challenge",
                AutoSDKShared1629dac811485089ManagedRulesVercelRulesetAction.Deny => "deny",
                AutoSDKShared1629dac811485089ManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1629dac811485089ManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared1629dac811485089ManagedRulesVercelRulesetAction.Challenge,
                "deny" => AutoSDKShared1629dac811485089ManagedRulesVercelRulesetAction.Deny,
                "log" => AutoSDKShared1629dac811485089ManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}