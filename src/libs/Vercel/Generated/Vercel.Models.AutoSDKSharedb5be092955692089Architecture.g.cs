
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb5be092955692089Architecture
    {
        /// <summary>
        ///
        /// </summary>
        Arm64,
        /// <summary>
        ///
        /// </summary>
        X8664,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb5be092955692089ArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb5be092955692089Architecture value)
        {
            return value switch
            {
                AutoSDKSharedb5be092955692089Architecture.Arm64 => "arm64",
                AutoSDKSharedb5be092955692089Architecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb5be092955692089Architecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => AutoSDKSharedb5be092955692089Architecture.Arm64,
                "x86_64" => AutoSDKSharedb5be092955692089Architecture.X8664,
                _ => null,
            };
        }
    }
}