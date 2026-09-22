
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0DeliveryVariant2Encoding
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
    public static class AutoSDKShared383028c008cc4ae0DeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0DeliveryVariant2Encoding value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0DeliveryVariant2Encoding.Json => "json",
                AutoSDKShared383028c008cc4ae0DeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0DeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKShared383028c008cc4ae0DeliveryVariant2Encoding.Json,
                "proto" => AutoSDKShared383028c008cc4ae0DeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}