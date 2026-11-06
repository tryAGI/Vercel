
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared25e1e81cf9eecd30ManagedRulesBotFilterAction
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
    public static class AutoSDKShared25e1e81cf9eecd30ManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared25e1e81cf9eecd30ManagedRulesBotFilterAction value)
        {
            return value switch
            {
                AutoSDKShared25e1e81cf9eecd30ManagedRulesBotFilterAction.Challenge => "challenge",
                AutoSDKShared25e1e81cf9eecd30ManagedRulesBotFilterAction.Deny => "deny",
                AutoSDKShared25e1e81cf9eecd30ManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared25e1e81cf9eecd30ManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared25e1e81cf9eecd30ManagedRulesBotFilterAction.Challenge,
                "deny" => AutoSDKShared25e1e81cf9eecd30ManagedRulesBotFilterAction.Deny,
                "log" => AutoSDKShared25e1e81cf9eecd30ManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}