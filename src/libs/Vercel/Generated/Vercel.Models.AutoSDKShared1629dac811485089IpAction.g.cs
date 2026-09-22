
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1629dac811485089IpAction
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
    public static class AutoSDKShared1629dac811485089IpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1629dac811485089IpAction value)
        {
            return value switch
            {
                AutoSDKShared1629dac811485089IpAction.Bypass => "bypass",
                AutoSDKShared1629dac811485089IpAction.Challenge => "challenge",
                AutoSDKShared1629dac811485089IpAction.Deny => "deny",
                AutoSDKShared1629dac811485089IpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1629dac811485089IpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKShared1629dac811485089IpAction.Bypass,
                "challenge" => AutoSDKShared1629dac811485089IpAction.Challenge,
                "deny" => AutoSDKShared1629dac811485089IpAction.Deny,
                "log" => AutoSDKShared1629dac811485089IpAction.Log,
                _ => null,
            };
        }
    }
}