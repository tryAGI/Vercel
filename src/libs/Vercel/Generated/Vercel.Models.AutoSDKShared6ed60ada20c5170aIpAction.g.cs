
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed60ada20c5170aIpAction
    {
        /// <summary>
        ///
        /// </summary>
        Bypass,
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
    public static class AutoSDKShared6ed60ada20c5170aIpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed60ada20c5170aIpAction value)
        {
            return value switch
            {
                AutoSDKShared6ed60ada20c5170aIpAction.Bypass => "bypass",
                AutoSDKShared6ed60ada20c5170aIpAction.Challenge => "challenge",
                AutoSDKShared6ed60ada20c5170aIpAction.Deny => "deny",
                AutoSDKShared6ed60ada20c5170aIpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed60ada20c5170aIpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKShared6ed60ada20c5170aIpAction.Bypass,
                "challenge" => AutoSDKShared6ed60ada20c5170aIpAction.Challenge,
                "deny" => AutoSDKShared6ed60ada20c5170aIpAction.Deny,
                "log" => AutoSDKShared6ed60ada20c5170aIpAction.Log,
                _ => null,
            };
        }
    }
}