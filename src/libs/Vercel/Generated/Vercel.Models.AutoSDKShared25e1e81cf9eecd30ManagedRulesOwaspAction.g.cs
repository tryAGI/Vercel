
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared25e1e81cf9eecd30ManagedRulesOwaspAction
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
    public static class AutoSDKShared25e1e81cf9eecd30ManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared25e1e81cf9eecd30ManagedRulesOwaspAction value)
        {
            return value switch
            {
                AutoSDKShared25e1e81cf9eecd30ManagedRulesOwaspAction.Challenge => "challenge",
                AutoSDKShared25e1e81cf9eecd30ManagedRulesOwaspAction.Deny => "deny",
                AutoSDKShared25e1e81cf9eecd30ManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared25e1e81cf9eecd30ManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared25e1e81cf9eecd30ManagedRulesOwaspAction.Challenge,
                "deny" => AutoSDKShared25e1e81cf9eecd30ManagedRulesOwaspAction.Deny,
                "log" => AutoSDKShared25e1e81cf9eecd30ManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}