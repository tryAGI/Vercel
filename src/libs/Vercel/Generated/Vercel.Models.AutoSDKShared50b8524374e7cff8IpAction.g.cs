
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared50b8524374e7cff8IpAction
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
    public static class AutoSDKShared50b8524374e7cff8IpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared50b8524374e7cff8IpAction value)
        {
            return value switch
            {
                AutoSDKShared50b8524374e7cff8IpAction.Bypass => "bypass",
                AutoSDKShared50b8524374e7cff8IpAction.Challenge => "challenge",
                AutoSDKShared50b8524374e7cff8IpAction.Deny => "deny",
                AutoSDKShared50b8524374e7cff8IpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared50b8524374e7cff8IpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKShared50b8524374e7cff8IpAction.Bypass,
                "challenge" => AutoSDKShared50b8524374e7cff8IpAction.Challenge,
                "deny" => AutoSDKShared50b8524374e7cff8IpAction.Deny,
                "log" => AutoSDKShared50b8524374e7cff8IpAction.Log,
                _ => null,
            };
        }
    }
}