
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared80effb7d5d0bf792ManagedRulesOwaspAction
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
    public static class AutoSDKShared80effb7d5d0bf792ManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared80effb7d5d0bf792ManagedRulesOwaspAction value)
        {
            return value switch
            {
                AutoSDKShared80effb7d5d0bf792ManagedRulesOwaspAction.Challenge => "challenge",
                AutoSDKShared80effb7d5d0bf792ManagedRulesOwaspAction.Deny => "deny",
                AutoSDKShared80effb7d5d0bf792ManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared80effb7d5d0bf792ManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared80effb7d5d0bf792ManagedRulesOwaspAction.Challenge,
                "deny" => AutoSDKShared80effb7d5d0bf792ManagedRulesOwaspAction.Deny,
                "log" => AutoSDKShared80effb7d5d0bf792ManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}