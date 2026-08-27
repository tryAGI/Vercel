
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDrainRequestDeliveryVariant3Encoding
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
    public static class UpdateDrainRequestDeliveryVariant3EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestDeliveryVariant3Encoding value)
        {
            return value switch
            {
                UpdateDrainRequestDeliveryVariant3Encoding.Json => "json",
                UpdateDrainRequestDeliveryVariant3Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestDeliveryVariant3Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => UpdateDrainRequestDeliveryVariant3Encoding.Json,
                "ndjson" => UpdateDrainRequestDeliveryVariant3Encoding.Ndjson,
                _ => null,
            };
        }
    }
}