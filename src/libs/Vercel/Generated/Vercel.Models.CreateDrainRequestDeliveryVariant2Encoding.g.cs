
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainRequestDeliveryVariant2Encoding
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Proto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainRequestDeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestDeliveryVariant2Encoding value)
        {
            return value switch
            {
                CreateDrainRequestDeliveryVariant2Encoding.Json => "json",
                CreateDrainRequestDeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestDeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateDrainRequestDeliveryVariant2Encoding.Json,
                "proto" => CreateDrainRequestDeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}