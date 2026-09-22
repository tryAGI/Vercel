
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Compression
    {
        /// <summary>
        ///
        /// </summary>
        Gzip,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Compression value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Compression.Gzip => "gzip",
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Compression.Gzip,
                "none" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}