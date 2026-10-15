
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareded558c13e366df17ManagedRulesAiBotsAction
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
    public static class AutoSDKShareded558c13e366df17ManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareded558c13e366df17ManagedRulesAiBotsAction value)
        {
            return value switch
            {
                AutoSDKShareded558c13e366df17ManagedRulesAiBotsAction.Challenge => "challenge",
                AutoSDKShareded558c13e366df17ManagedRulesAiBotsAction.Deny => "deny",
                AutoSDKShareded558c13e366df17ManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareded558c13e366df17ManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShareded558c13e366df17ManagedRulesAiBotsAction.Challenge,
                "deny" => AutoSDKShareded558c13e366df17ManagedRulesAiBotsAction.Deny,
                "log" => AutoSDKShareded558c13e366df17ManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}