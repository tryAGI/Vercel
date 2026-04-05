
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant1DeliveryVariant1Compression
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
    public static class CreateDrainResponseVariant1DeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant1DeliveryVariant1Compression value)
        {
            return value switch
            {
                CreateDrainResponseVariant1DeliveryVariant1Compression.Gzip => "gzip",
                CreateDrainResponseVariant1DeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant1DeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => CreateDrainResponseVariant1DeliveryVariant1Compression.Gzip,
                "none" => CreateDrainResponseVariant1DeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}