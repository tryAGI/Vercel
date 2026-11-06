
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared25e1e81cf9eecd30ManagedRulesTrafficSourcesAction
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
    public static class AutoSDKShared25e1e81cf9eecd30ManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared25e1e81cf9eecd30ManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                AutoSDKShared25e1e81cf9eecd30ManagedRulesTrafficSourcesAction.Challenge => "challenge",
                AutoSDKShared25e1e81cf9eecd30ManagedRulesTrafficSourcesAction.Deny => "deny",
                AutoSDKShared25e1e81cf9eecd30ManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared25e1e81cf9eecd30ManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared25e1e81cf9eecd30ManagedRulesTrafficSourcesAction.Challenge,
                "deny" => AutoSDKShared25e1e81cf9eecd30ManagedRulesTrafficSourcesAction.Deny,
                "log" => AutoSDKShared25e1e81cf9eecd30ManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}