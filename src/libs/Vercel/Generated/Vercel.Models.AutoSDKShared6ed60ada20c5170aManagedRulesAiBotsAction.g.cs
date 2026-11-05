
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed60ada20c5170aManagedRulesAiBotsAction
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
    public static class AutoSDKShared6ed60ada20c5170aManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed60ada20c5170aManagedRulesAiBotsAction value)
        {
            return value switch
            {
                AutoSDKShared6ed60ada20c5170aManagedRulesAiBotsAction.Challenge => "challenge",
                AutoSDKShared6ed60ada20c5170aManagedRulesAiBotsAction.Deny => "deny",
                AutoSDKShared6ed60ada20c5170aManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed60ada20c5170aManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared6ed60ada20c5170aManagedRulesAiBotsAction.Challenge,
                "deny" => AutoSDKShared6ed60ada20c5170aManagedRulesAiBotsAction.Deny,
                "log" => AutoSDKShared6ed60ada20c5170aManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}