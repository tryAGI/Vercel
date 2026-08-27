
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDrainResponseVariant2DeliveryVariant4Encoding
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
    public static class UpdateDrainResponseVariant2DeliveryVariant4EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2DeliveryVariant4Encoding value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2DeliveryVariant4Encoding.Json => "json",
                UpdateDrainResponseVariant2DeliveryVariant4Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2DeliveryVariant4Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => UpdateDrainResponseVariant2DeliveryVariant4Encoding.Json,
                "ndjson" => UpdateDrainResponseVariant2DeliveryVariant4Encoding.Ndjson,
                _ => null,
            };
        }
    }
}