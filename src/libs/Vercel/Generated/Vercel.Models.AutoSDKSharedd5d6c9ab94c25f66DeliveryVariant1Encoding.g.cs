
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Encoding
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
    public static class AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Encoding value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Encoding.Json => "json",
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Encoding.Json,
                "ndjson" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Encoding.Ndjson,
                _ => null,
            };
        }
    }
}