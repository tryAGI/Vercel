
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDrainResponseVariant1DeliveryVariant4Encoding
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
    public static class GetDrainResponseVariant1DeliveryVariant4EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant1DeliveryVariant4Encoding value)
        {
            return value switch
            {
                GetDrainResponseVariant1DeliveryVariant4Encoding.Json => "json",
                GetDrainResponseVariant1DeliveryVariant4Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant1DeliveryVariant4Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetDrainResponseVariant1DeliveryVariant4Encoding.Json,
                "ndjson" => GetDrainResponseVariant1DeliveryVariant4Encoding.Ndjson,
                _ => null,
            };
        }
    }
}