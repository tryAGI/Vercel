
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf0cc1038a078908fManagedRulesAiBotsAction
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
    public static class AutoSDKSharedf0cc1038a078908fManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf0cc1038a078908fManagedRulesAiBotsAction value)
        {
            return value switch
            {
                AutoSDKSharedf0cc1038a078908fManagedRulesAiBotsAction.Challenge => "challenge",
                AutoSDKSharedf0cc1038a078908fManagedRulesAiBotsAction.Deny => "deny",
                AutoSDKSharedf0cc1038a078908fManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf0cc1038a078908fManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedf0cc1038a078908fManagedRulesAiBotsAction.Challenge,
                "deny" => AutoSDKSharedf0cc1038a078908fManagedRulesAiBotsAction.Deny,
                "log" => AutoSDKSharedf0cc1038a078908fManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}