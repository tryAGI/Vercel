
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7e5cde0fd7c87b94ManagedRulesTrafficSourcesAction
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
    public static class AutoSDKShared7e5cde0fd7c87b94ManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7e5cde0fd7c87b94ManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                AutoSDKShared7e5cde0fd7c87b94ManagedRulesTrafficSourcesAction.Challenge => "challenge",
                AutoSDKShared7e5cde0fd7c87b94ManagedRulesTrafficSourcesAction.Deny => "deny",
                AutoSDKShared7e5cde0fd7c87b94ManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7e5cde0fd7c87b94ManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared7e5cde0fd7c87b94ManagedRulesTrafficSourcesAction.Challenge,
                "deny" => AutoSDKShared7e5cde0fd7c87b94ManagedRulesTrafficSourcesAction.Deny,
                "log" => AutoSDKShared7e5cde0fd7c87b94ManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}