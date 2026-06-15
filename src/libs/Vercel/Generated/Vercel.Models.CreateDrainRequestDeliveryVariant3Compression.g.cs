
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainRequestDeliveryVariant3Compression
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainRequestDeliveryVariant3CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestDeliveryVariant3Compression value)
        {
            return value switch
            {
                CreateDrainRequestDeliveryVariant3Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestDeliveryVariant3Compression? ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateDrainRequestDeliveryVariant3Compression.None,
                _ => null,
            };
        }
    }
}