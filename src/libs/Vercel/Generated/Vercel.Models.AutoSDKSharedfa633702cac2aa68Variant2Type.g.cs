
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa633702cac2aa68Variant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Otlphttp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfa633702cac2aa68Variant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa633702cac2aa68Variant2Type value)
        {
            return value switch
            {
                AutoSDKSharedfa633702cac2aa68Variant2Type.Otlphttp => "otlphttp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa633702cac2aa68Variant2Type? ToEnum(string value)
        {
            return value switch
            {
                "otlphttp" => AutoSDKSharedfa633702cac2aa68Variant2Type.Otlphttp,
                _ => null,
            };
        }
    }
}