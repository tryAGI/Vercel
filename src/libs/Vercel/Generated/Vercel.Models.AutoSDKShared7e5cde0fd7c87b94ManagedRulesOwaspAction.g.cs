
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7e5cde0fd7c87b94ManagedRulesOwaspAction
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
    public static class AutoSDKShared7e5cde0fd7c87b94ManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7e5cde0fd7c87b94ManagedRulesOwaspAction value)
        {
            return value switch
            {
                AutoSDKShared7e5cde0fd7c87b94ManagedRulesOwaspAction.Challenge => "challenge",
                AutoSDKShared7e5cde0fd7c87b94ManagedRulesOwaspAction.Deny => "deny",
                AutoSDKShared7e5cde0fd7c87b94ManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7e5cde0fd7c87b94ManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared7e5cde0fd7c87b94ManagedRulesOwaspAction.Challenge,
                "deny" => AutoSDKShared7e5cde0fd7c87b94ManagedRulesOwaspAction.Deny,
                "log" => AutoSDKShared7e5cde0fd7c87b94ManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}