
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed60ada20c5170aManagedRulesBotProtectionAction
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
    public static class AutoSDKShared6ed60ada20c5170aManagedRulesBotProtectionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed60ada20c5170aManagedRulesBotProtectionAction value)
        {
            return value switch
            {
                AutoSDKShared6ed60ada20c5170aManagedRulesBotProtectionAction.Challenge => "challenge",
                AutoSDKShared6ed60ada20c5170aManagedRulesBotProtectionAction.Deny => "deny",
                AutoSDKShared6ed60ada20c5170aManagedRulesBotProtectionAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed60ada20c5170aManagedRulesBotProtectionAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared6ed60ada20c5170aManagedRulesBotProtectionAction.Challenge,
                "deny" => AutoSDKShared6ed60ada20c5170aManagedRulesBotProtectionAction.Deny,
                "log" => AutoSDKShared6ed60ada20c5170aManagedRulesBotProtectionAction.Log,
                _ => null,
            };
        }
    }
}