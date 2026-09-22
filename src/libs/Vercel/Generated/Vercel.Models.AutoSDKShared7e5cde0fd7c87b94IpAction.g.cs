
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7e5cde0fd7c87b94IpAction
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
    public static class AutoSDKShared7e5cde0fd7c87b94IpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7e5cde0fd7c87b94IpAction value)
        {
            return value switch
            {
                AutoSDKShared7e5cde0fd7c87b94IpAction.Bypass => "bypass",
                AutoSDKShared7e5cde0fd7c87b94IpAction.Challenge => "challenge",
                AutoSDKShared7e5cde0fd7c87b94IpAction.Deny => "deny",
                AutoSDKShared7e5cde0fd7c87b94IpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7e5cde0fd7c87b94IpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKShared7e5cde0fd7c87b94IpAction.Bypass,
                "challenge" => AutoSDKShared7e5cde0fd7c87b94IpAction.Challenge,
                "deny" => AutoSDKShared7e5cde0fd7c87b94IpAction.Deny,
                "log" => AutoSDKShared7e5cde0fd7c87b94IpAction.Log,
                _ => null,
            };
        }
    }
}