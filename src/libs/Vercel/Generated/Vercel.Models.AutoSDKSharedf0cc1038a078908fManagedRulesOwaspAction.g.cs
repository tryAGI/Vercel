
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf0cc1038a078908fManagedRulesOwaspAction
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
    public static class AutoSDKSharedf0cc1038a078908fManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf0cc1038a078908fManagedRulesOwaspAction value)
        {
            return value switch
            {
                AutoSDKSharedf0cc1038a078908fManagedRulesOwaspAction.Challenge => "challenge",
                AutoSDKSharedf0cc1038a078908fManagedRulesOwaspAction.Deny => "deny",
                AutoSDKSharedf0cc1038a078908fManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf0cc1038a078908fManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedf0cc1038a078908fManagedRulesOwaspAction.Challenge,
                "deny" => AutoSDKSharedf0cc1038a078908fManagedRulesOwaspAction.Deny,
                "log" => AutoSDKSharedf0cc1038a078908fManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}