
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed60ada20c5170aManagedRulesOwaspAction
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
    public static class AutoSDKShared6ed60ada20c5170aManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed60ada20c5170aManagedRulesOwaspAction value)
        {
            return value switch
            {
                AutoSDKShared6ed60ada20c5170aManagedRulesOwaspAction.Challenge => "challenge",
                AutoSDKShared6ed60ada20c5170aManagedRulesOwaspAction.Deny => "deny",
                AutoSDKShared6ed60ada20c5170aManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed60ada20c5170aManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared6ed60ada20c5170aManagedRulesOwaspAction.Challenge,
                "deny" => AutoSDKShared6ed60ada20c5170aManagedRulesOwaspAction.Deny,
                "log" => AutoSDKShared6ed60ada20c5170aManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}