
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared80effb7d5d0bf792ManagedRulesAiBotsAction
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
    public static class AutoSDKShared80effb7d5d0bf792ManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared80effb7d5d0bf792ManagedRulesAiBotsAction value)
        {
            return value switch
            {
                AutoSDKShared80effb7d5d0bf792ManagedRulesAiBotsAction.Challenge => "challenge",
                AutoSDKShared80effb7d5d0bf792ManagedRulesAiBotsAction.Deny => "deny",
                AutoSDKShared80effb7d5d0bf792ManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared80effb7d5d0bf792ManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared80effb7d5d0bf792ManagedRulesAiBotsAction.Challenge,
                "deny" => AutoSDKShared80effb7d5d0bf792ManagedRulesAiBotsAction.Deny,
                "log" => AutoSDKShared80effb7d5d0bf792ManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}