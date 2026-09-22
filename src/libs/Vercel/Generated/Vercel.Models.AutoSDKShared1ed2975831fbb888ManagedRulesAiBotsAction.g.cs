
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1ed2975831fbb888ManagedRulesAiBotsAction
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
    public static class AutoSDKShared1ed2975831fbb888ManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1ed2975831fbb888ManagedRulesAiBotsAction value)
        {
            return value switch
            {
                AutoSDKShared1ed2975831fbb888ManagedRulesAiBotsAction.Challenge => "challenge",
                AutoSDKShared1ed2975831fbb888ManagedRulesAiBotsAction.Deny => "deny",
                AutoSDKShared1ed2975831fbb888ManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1ed2975831fbb888ManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared1ed2975831fbb888ManagedRulesAiBotsAction.Challenge,
                "deny" => AutoSDKShared1ed2975831fbb888ManagedRulesAiBotsAction.Deny,
                "log" => AutoSDKShared1ed2975831fbb888ManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}