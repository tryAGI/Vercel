
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainRequestDeliveryVariant1Encoding
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
    public static class UpdateDrainRequestDeliveryVariant1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestDeliveryVariant1Encoding value)
        {
            return value switch
            {
                UpdateDrainRequestDeliveryVariant1Encoding.Json => "json",
                UpdateDrainRequestDeliveryVariant1Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestDeliveryVariant1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => UpdateDrainRequestDeliveryVariant1Encoding.Json,
                "ndjson" => UpdateDrainRequestDeliveryVariant1Encoding.Ndjson,
                _ => null,
            };
        }
    }
}