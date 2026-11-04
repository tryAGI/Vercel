
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared82154186cc88506cHaVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared82154186cc88506cHaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared82154186cc88506cHaVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared82154186cc88506cHaVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared82154186cc88506cHaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => AutoSDKShared82154186cc88506cHaVariant1Type.Host,
                _ => null,
            };
        }
    }
}