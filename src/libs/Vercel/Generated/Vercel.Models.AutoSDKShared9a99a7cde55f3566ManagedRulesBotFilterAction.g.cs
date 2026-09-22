
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilterAction
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
    public static class AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilterAction value)
        {
            return value switch
            {
                AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilterAction.Challenge => "challenge",
                AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilterAction.Deny => "deny",
                AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilterAction.Challenge,
                "deny" => AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilterAction.Deny,
                "log" => AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}