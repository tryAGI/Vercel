
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared18dae8be9b6aa4ffManagedRulesOwaspAction
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
    public static class AutoSDKShared18dae8be9b6aa4ffManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared18dae8be9b6aa4ffManagedRulesOwaspAction value)
        {
            return value switch
            {
                AutoSDKShared18dae8be9b6aa4ffManagedRulesOwaspAction.Challenge => "challenge",
                AutoSDKShared18dae8be9b6aa4ffManagedRulesOwaspAction.Deny => "deny",
                AutoSDKShared18dae8be9b6aa4ffManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared18dae8be9b6aa4ffManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared18dae8be9b6aa4ffManagedRulesOwaspAction.Challenge,
                "deny" => AutoSDKShared18dae8be9b6aa4ffManagedRulesOwaspAction.Deny,
                "log" => AutoSDKShared18dae8be9b6aa4ffManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}