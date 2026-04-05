
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant1DeliveryVariant1Encoding
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
    public static class UpdateDrainResponseVariant1DeliveryVariant1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1DeliveryVariant1Encoding value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1DeliveryVariant1Encoding.Json => "json",
                UpdateDrainResponseVariant1DeliveryVariant1Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1DeliveryVariant1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => UpdateDrainResponseVariant1DeliveryVariant1Encoding.Json,
                "ndjson" => UpdateDrainResponseVariant1DeliveryVariant1Encoding.Ndjson,
                _ => null,
            };
        }
    }
}