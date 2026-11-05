
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSourcesAction
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
    public static class AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSourcesAction.Challenge => "challenge",
                AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSourcesAction.Deny => "deny",
                AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSourcesAction.Challenge,
                "deny" => AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSourcesAction.Deny,
                "log" => AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}