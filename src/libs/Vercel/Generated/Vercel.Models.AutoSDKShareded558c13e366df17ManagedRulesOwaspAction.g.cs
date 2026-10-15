
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareded558c13e366df17ManagedRulesOwaspAction
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
    public static class AutoSDKShareded558c13e366df17ManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareded558c13e366df17ManagedRulesOwaspAction value)
        {
            return value switch
            {
                AutoSDKShareded558c13e366df17ManagedRulesOwaspAction.Challenge => "challenge",
                AutoSDKShareded558c13e366df17ManagedRulesOwaspAction.Deny => "deny",
                AutoSDKShareded558c13e366df17ManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareded558c13e366df17ManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShareded558c13e366df17ManagedRulesOwaspAction.Challenge,
                "deny" => AutoSDKShareded558c13e366df17ManagedRulesOwaspAction.Deny,
                "log" => AutoSDKShareded558c13e366df17ManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}