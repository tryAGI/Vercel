
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared62800e8e12d3c345HaVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared62800e8e12d3c345HaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared62800e8e12d3c345HaVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared62800e8e12d3c345HaVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared62800e8e12d3c345HaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => AutoSDKShared62800e8e12d3c345HaVariant1Type.Host,
                _ => null,
            };
        }
    }
}