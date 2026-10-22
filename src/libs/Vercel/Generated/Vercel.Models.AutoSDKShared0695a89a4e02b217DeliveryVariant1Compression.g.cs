
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217DeliveryVariant1Compression
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
    public static class AutoSDKShared0695a89a4e02b217DeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217DeliveryVariant1Compression value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217DeliveryVariant1Compression.Gzip => "gzip",
                AutoSDKShared0695a89a4e02b217DeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217DeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => AutoSDKShared0695a89a4e02b217DeliveryVariant1Compression.Gzip,
                "none" => AutoSDKShared0695a89a4e02b217DeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}