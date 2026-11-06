
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared25e1e81cf9eecd30ManagedRulesAiBotsAction
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
    public static class AutoSDKShared25e1e81cf9eecd30ManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared25e1e81cf9eecd30ManagedRulesAiBotsAction value)
        {
            return value switch
            {
                AutoSDKShared25e1e81cf9eecd30ManagedRulesAiBotsAction.Challenge => "challenge",
                AutoSDKShared25e1e81cf9eecd30ManagedRulesAiBotsAction.Deny => "deny",
                AutoSDKShared25e1e81cf9eecd30ManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared25e1e81cf9eecd30ManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared25e1e81cf9eecd30ManagedRulesAiBotsAction.Challenge,
                "deny" => AutoSDKShared25e1e81cf9eecd30ManagedRulesAiBotsAction.Deny,
                "log" => AutoSDKShared25e1e81cf9eecd30ManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}