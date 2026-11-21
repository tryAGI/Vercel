
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb5be092955692089MaxDuration
    {
        /// <summary>
        ///
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb5be092955692089MaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb5be092955692089MaxDuration value)
        {
            return value switch
            {
                AutoSDKSharedb5be092955692089MaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb5be092955692089MaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => AutoSDKSharedb5be092955692089MaxDuration.Max,
                _ => null,
            };
        }
    }
}