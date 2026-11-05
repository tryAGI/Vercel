
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb4cb9cbf2561e851IpAction
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
    public static class AutoSDKSharedb4cb9cbf2561e851IpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb4cb9cbf2561e851IpAction value)
        {
            return value switch
            {
                AutoSDKSharedb4cb9cbf2561e851IpAction.Bypass => "bypass",
                AutoSDKSharedb4cb9cbf2561e851IpAction.Challenge => "challenge",
                AutoSDKSharedb4cb9cbf2561e851IpAction.Deny => "deny",
                AutoSDKSharedb4cb9cbf2561e851IpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb4cb9cbf2561e851IpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKSharedb4cb9cbf2561e851IpAction.Bypass,
                "challenge" => AutoSDKSharedb4cb9cbf2561e851IpAction.Challenge,
                "deny" => AutoSDKSharedb4cb9cbf2561e851IpAction.Deny,
                "log" => AutoSDKSharedb4cb9cbf2561e851IpAction.Log,
                _ => null,
            };
        }
    }
}