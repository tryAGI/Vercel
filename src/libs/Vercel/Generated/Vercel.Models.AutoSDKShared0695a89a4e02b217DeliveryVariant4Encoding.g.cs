
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217DeliveryVariant4Encoding
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
    public static class AutoSDKShared0695a89a4e02b217DeliveryVariant4EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217DeliveryVariant4Encoding value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217DeliveryVariant4Encoding.Json => "json",
                AutoSDKShared0695a89a4e02b217DeliveryVariant4Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217DeliveryVariant4Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKShared0695a89a4e02b217DeliveryVariant4Encoding.Json,
                "ndjson" => AutoSDKShared0695a89a4e02b217DeliveryVariant4Encoding.Ndjson,
                _ => null,
            };
        }
    }
}