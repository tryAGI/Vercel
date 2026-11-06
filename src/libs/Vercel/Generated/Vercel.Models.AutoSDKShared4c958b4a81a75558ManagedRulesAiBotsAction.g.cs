
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4c958b4a81a75558ManagedRulesAiBotsAction
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
    public static class AutoSDKShared4c958b4a81a75558ManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4c958b4a81a75558ManagedRulesAiBotsAction value)
        {
            return value switch
            {
                AutoSDKShared4c958b4a81a75558ManagedRulesAiBotsAction.Challenge => "challenge",
                AutoSDKShared4c958b4a81a75558ManagedRulesAiBotsAction.Deny => "deny",
                AutoSDKShared4c958b4a81a75558ManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4c958b4a81a75558ManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared4c958b4a81a75558ManagedRulesAiBotsAction.Challenge,
                "deny" => AutoSDKShared4c958b4a81a75558ManagedRulesAiBotsAction.Deny,
                "log" => AutoSDKShared4c958b4a81a75558ManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}