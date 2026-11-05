
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction
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
    public static class AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction value)
        {
            return value switch
            {
                AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction.Challenge => "challenge",
                AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction.Deny => "deny",
                AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction.Challenge,
                "deny" => AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction.Deny,
                "log" => AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}