
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Encoding
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
    public static class AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Encoding value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Encoding.Json => "json",
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Encoding.Json,
                "ndjson" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant4Encoding.Ndjson,
                _ => null,
            };
        }
    }
}