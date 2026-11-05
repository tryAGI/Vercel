
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedeb5fe0ead5db865cManagedRulesOwaspAction
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
    public static class AutoSDKSharedeb5fe0ead5db865cManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedeb5fe0ead5db865cManagedRulesOwaspAction value)
        {
            return value switch
            {
                AutoSDKSharedeb5fe0ead5db865cManagedRulesOwaspAction.Challenge => "challenge",
                AutoSDKSharedeb5fe0ead5db865cManagedRulesOwaspAction.Deny => "deny",
                AutoSDKSharedeb5fe0ead5db865cManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedeb5fe0ead5db865cManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedeb5fe0ead5db865cManagedRulesOwaspAction.Challenge,
                "deny" => AutoSDKSharedeb5fe0ead5db865cManagedRulesOwaspAction.Deny,
                "log" => AutoSDKSharedeb5fe0ead5db865cManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}