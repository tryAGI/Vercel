
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression
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
    public static class GetDrainsResponseDrainsVariant2ItemDeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression.Gzip => "gzip",
                GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression.Gzip,
                "none" => GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}