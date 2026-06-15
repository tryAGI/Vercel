
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainRequestDeliveryVariant3Encoding
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
    public static class CreateDrainRequestDeliveryVariant3EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestDeliveryVariant3Encoding value)
        {
            return value switch
            {
                CreateDrainRequestDeliveryVariant3Encoding.Json => "json",
                CreateDrainRequestDeliveryVariant3Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestDeliveryVariant3Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateDrainRequestDeliveryVariant3Encoding.Json,
                "ndjson" => CreateDrainRequestDeliveryVariant3Encoding.Ndjson,
                _ => null,
            };
        }
    }
}