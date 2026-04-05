
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainRequestDeliveryVariant1Compression
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
    public static class UpdateDrainRequestDeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestDeliveryVariant1Compression value)
        {
            return value switch
            {
                UpdateDrainRequestDeliveryVariant1Compression.Gzip => "gzip",
                UpdateDrainRequestDeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestDeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => UpdateDrainRequestDeliveryVariant1Compression.Gzip,
                "none" => UpdateDrainRequestDeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}