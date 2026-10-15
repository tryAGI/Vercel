
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared80effb7d5d0bf792IpAction
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
    public static class AutoSDKShared80effb7d5d0bf792IpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared80effb7d5d0bf792IpAction value)
        {
            return value switch
            {
                AutoSDKShared80effb7d5d0bf792IpAction.Bypass => "bypass",
                AutoSDKShared80effb7d5d0bf792IpAction.Challenge => "challenge",
                AutoSDKShared80effb7d5d0bf792IpAction.Deny => "deny",
                AutoSDKShared80effb7d5d0bf792IpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared80effb7d5d0bf792IpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKShared80effb7d5d0bf792IpAction.Bypass,
                "challenge" => AutoSDKShared80effb7d5d0bf792IpAction.Challenge,
                "deny" => AutoSDKShared80effb7d5d0bf792IpAction.Deny,
                "log" => AutoSDKShared80effb7d5d0bf792IpAction.Log,
                _ => null,
            };
        }
    }
}