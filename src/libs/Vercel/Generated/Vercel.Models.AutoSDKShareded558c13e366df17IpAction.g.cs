
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareded558c13e366df17IpAction
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
    public static class AutoSDKShareded558c13e366df17IpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareded558c13e366df17IpAction value)
        {
            return value switch
            {
                AutoSDKShareded558c13e366df17IpAction.Bypass => "bypass",
                AutoSDKShareded558c13e366df17IpAction.Challenge => "challenge",
                AutoSDKShareded558c13e366df17IpAction.Deny => "deny",
                AutoSDKShareded558c13e366df17IpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareded558c13e366df17IpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKShareded558c13e366df17IpAction.Bypass,
                "challenge" => AutoSDKShareded558c13e366df17IpAction.Challenge,
                "deny" => AutoSDKShareded558c13e366df17IpAction.Deny,
                "log" => AutoSDKShareded558c13e366df17IpAction.Log,
                _ => null,
            };
        }
    }
}