
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0DeliveryVariant4Encoding
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
    public static class AutoSDKShared383028c008cc4ae0DeliveryVariant4EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0DeliveryVariant4Encoding value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0DeliveryVariant4Encoding.Json => "json",
                AutoSDKShared383028c008cc4ae0DeliveryVariant4Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0DeliveryVariant4Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKShared383028c008cc4ae0DeliveryVariant4Encoding.Json,
                "ndjson" => AutoSDKShared383028c008cc4ae0DeliveryVariant4Encoding.Ndjson,
                _ => null,
            };
        }
    }
}