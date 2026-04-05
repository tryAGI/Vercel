
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2DeliveryVariant1Encoding
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
    public static class GetDrainResponseVariant2DeliveryVariant1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2DeliveryVariant1Encoding value)
        {
            return value switch
            {
                GetDrainResponseVariant2DeliveryVariant1Encoding.Json => "json",
                GetDrainResponseVariant2DeliveryVariant1Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2DeliveryVariant1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetDrainResponseVariant2DeliveryVariant1Encoding.Json,
                "ndjson" => GetDrainResponseVariant2DeliveryVariant1Encoding.Ndjson,
                _ => null,
            };
        }
    }
}