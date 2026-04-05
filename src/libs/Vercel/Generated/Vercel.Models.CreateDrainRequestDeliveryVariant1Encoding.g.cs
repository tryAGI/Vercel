
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainRequestDeliveryVariant1Encoding
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Ndjson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainRequestDeliveryVariant1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestDeliveryVariant1Encoding value)
        {
            return value switch
            {
                CreateDrainRequestDeliveryVariant1Encoding.Json => "json",
                CreateDrainRequestDeliveryVariant1Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestDeliveryVariant1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateDrainRequestDeliveryVariant1Encoding.Json,
                "ndjson" => CreateDrainRequestDeliveryVariant1Encoding.Ndjson,
                _ => null,
            };
        }
    }
}