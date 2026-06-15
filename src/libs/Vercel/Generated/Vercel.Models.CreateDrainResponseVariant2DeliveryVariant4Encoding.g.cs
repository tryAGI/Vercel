
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2DeliveryVariant4Encoding
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
    public static class CreateDrainResponseVariant2DeliveryVariant4EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2DeliveryVariant4Encoding value)
        {
            return value switch
            {
                CreateDrainResponseVariant2DeliveryVariant4Encoding.Json => "json",
                CreateDrainResponseVariant2DeliveryVariant4Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2DeliveryVariant4Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateDrainResponseVariant2DeliveryVariant4Encoding.Json,
                "ndjson" => CreateDrainResponseVariant2DeliveryVariant4Encoding.Ndjson,
                _ => null,
            };
        }
    }
}