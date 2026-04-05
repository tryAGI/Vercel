
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Compression
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
    public static class GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Compression value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Compression.Gzip => "gzip",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Compression.Gzip,
                "none" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}