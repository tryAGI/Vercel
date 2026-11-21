
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb5be092955692089AffinityMode
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb5be092955692089AffinityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb5be092955692089AffinityMode value)
        {
            return value switch
            {
                AutoSDKSharedb5be092955692089AffinityMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb5be092955692089AffinityMode? ToEnum(string value)
        {
            return value switch
            {
                "strict" => AutoSDKSharedb5be092955692089AffinityMode.Strict,
                _ => null,
            };
        }
    }
}