
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf0cc1038a078908fManagedRulesTrafficSourcesAction
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
    public static class AutoSDKSharedf0cc1038a078908fManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf0cc1038a078908fManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                AutoSDKSharedf0cc1038a078908fManagedRulesTrafficSourcesAction.Challenge => "challenge",
                AutoSDKSharedf0cc1038a078908fManagedRulesTrafficSourcesAction.Deny => "deny",
                AutoSDKSharedf0cc1038a078908fManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf0cc1038a078908fManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedf0cc1038a078908fManagedRulesTrafficSourcesAction.Challenge,
                "deny" => AutoSDKSharedf0cc1038a078908fManagedRulesTrafficSourcesAction.Deny,
                "log" => AutoSDKSharedf0cc1038a078908fManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}