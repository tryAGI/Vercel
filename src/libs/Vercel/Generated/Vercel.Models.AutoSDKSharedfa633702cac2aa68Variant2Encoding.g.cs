
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa633702cac2aa68Variant2Encoding
    {
        /// <summary>
        ///
        /// </summary>
        Json,
        /// <summary>
        ///
        /// </summary>
        Proto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfa633702cac2aa68Variant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa633702cac2aa68Variant2Encoding value)
        {
            return value switch
            {
                AutoSDKSharedfa633702cac2aa68Variant2Encoding.Json => "json",
                AutoSDKSharedfa633702cac2aa68Variant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa633702cac2aa68Variant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKSharedfa633702cac2aa68Variant2Encoding.Json,
                "proto" => AutoSDKSharedfa633702cac2aa68Variant2Encoding.Proto,
                _ => null,
            };
        }
    }
}