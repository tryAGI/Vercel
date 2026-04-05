
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2DeliveryVariant1Compression
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
    public static class GetDrainResponseVariant2DeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2DeliveryVariant1Compression value)
        {
            return value switch
            {
                GetDrainResponseVariant2DeliveryVariant1Compression.Gzip => "gzip",
                GetDrainResponseVariant2DeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2DeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => GetDrainResponseVariant2DeliveryVariant1Compression.Gzip,
                "none" => GetDrainResponseVariant2DeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}