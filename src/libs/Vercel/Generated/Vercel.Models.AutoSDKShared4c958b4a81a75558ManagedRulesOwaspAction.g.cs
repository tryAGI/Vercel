
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4c958b4a81a75558ManagedRulesOwaspAction
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
    public static class AutoSDKShared4c958b4a81a75558ManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4c958b4a81a75558ManagedRulesOwaspAction value)
        {
            return value switch
            {
                AutoSDKShared4c958b4a81a75558ManagedRulesOwaspAction.Challenge => "challenge",
                AutoSDKShared4c958b4a81a75558ManagedRulesOwaspAction.Deny => "deny",
                AutoSDKShared4c958b4a81a75558ManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4c958b4a81a75558ManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared4c958b4a81a75558ManagedRulesOwaspAction.Challenge,
                "deny" => AutoSDKShared4c958b4a81a75558ManagedRulesOwaspAction.Deny,
                "log" => AutoSDKShared4c958b4a81a75558ManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}