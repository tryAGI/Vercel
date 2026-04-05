
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression
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
    public static class GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression.Gzip => "gzip",
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression.Gzip,
                "none" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}