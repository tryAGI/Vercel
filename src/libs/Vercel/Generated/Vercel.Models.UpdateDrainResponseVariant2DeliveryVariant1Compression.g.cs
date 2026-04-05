
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2DeliveryVariant1Compression
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
    public static class UpdateDrainResponseVariant2DeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2DeliveryVariant1Compression value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2DeliveryVariant1Compression.Gzip => "gzip",
                UpdateDrainResponseVariant2DeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2DeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => UpdateDrainResponseVariant2DeliveryVariant1Compression.Gzip,
                "none" => UpdateDrainResponseVariant2DeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}