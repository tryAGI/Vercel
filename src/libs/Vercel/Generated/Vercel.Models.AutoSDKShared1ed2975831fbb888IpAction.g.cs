
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1ed2975831fbb888IpAction
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
    public static class AutoSDKShared1ed2975831fbb888IpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1ed2975831fbb888IpAction value)
        {
            return value switch
            {
                AutoSDKShared1ed2975831fbb888IpAction.Bypass => "bypass",
                AutoSDKShared1ed2975831fbb888IpAction.Challenge => "challenge",
                AutoSDKShared1ed2975831fbb888IpAction.Deny => "deny",
                AutoSDKShared1ed2975831fbb888IpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1ed2975831fbb888IpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKShared1ed2975831fbb888IpAction.Bypass,
                "challenge" => AutoSDKShared1ed2975831fbb888IpAction.Challenge,
                "deny" => AutoSDKShared1ed2975831fbb888IpAction.Deny,
                "log" => AutoSDKShared1ed2975831fbb888IpAction.Log,
                _ => null,
            };
        }
    }
}