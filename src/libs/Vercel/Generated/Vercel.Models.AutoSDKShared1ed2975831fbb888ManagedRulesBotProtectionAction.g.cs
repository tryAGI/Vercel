
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1ed2975831fbb888ManagedRulesBotProtectionAction
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
    public static class AutoSDKShared1ed2975831fbb888ManagedRulesBotProtectionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1ed2975831fbb888ManagedRulesBotProtectionAction value)
        {
            return value switch
            {
                AutoSDKShared1ed2975831fbb888ManagedRulesBotProtectionAction.Challenge => "challenge",
                AutoSDKShared1ed2975831fbb888ManagedRulesBotProtectionAction.Deny => "deny",
                AutoSDKShared1ed2975831fbb888ManagedRulesBotProtectionAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1ed2975831fbb888ManagedRulesBotProtectionAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared1ed2975831fbb888ManagedRulesBotProtectionAction.Challenge,
                "deny" => AutoSDKShared1ed2975831fbb888ManagedRulesBotProtectionAction.Deny,
                "log" => AutoSDKShared1ed2975831fbb888ManagedRulesBotProtectionAction.Log,
                _ => null,
            };
        }
    }
}