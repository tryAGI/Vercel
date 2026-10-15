
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared50b8524374e7cff8ManagedRulesAiBotsAction
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
    public static class AutoSDKShared50b8524374e7cff8ManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared50b8524374e7cff8ManagedRulesAiBotsAction value)
        {
            return value switch
            {
                AutoSDKShared50b8524374e7cff8ManagedRulesAiBotsAction.Challenge => "challenge",
                AutoSDKShared50b8524374e7cff8ManagedRulesAiBotsAction.Deny => "deny",
                AutoSDKShared50b8524374e7cff8ManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared50b8524374e7cff8ManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared50b8524374e7cff8ManagedRulesAiBotsAction.Challenge,
                "deny" => AutoSDKShared50b8524374e7cff8ManagedRulesAiBotsAction.Deny,
                "log" => AutoSDKShared50b8524374e7cff8ManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}