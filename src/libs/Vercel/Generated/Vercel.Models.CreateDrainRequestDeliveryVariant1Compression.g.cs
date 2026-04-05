
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainRequestDeliveryVariant1Compression
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
    public static class CreateDrainRequestDeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestDeliveryVariant1Compression value)
        {
            return value switch
            {
                CreateDrainRequestDeliveryVariant1Compression.Gzip => "gzip",
                CreateDrainRequestDeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestDeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => CreateDrainRequestDeliveryVariant1Compression.Gzip,
                "none" => CreateDrainRequestDeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}