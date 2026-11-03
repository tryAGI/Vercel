
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared56f06376e757011bDeliveryVariant1Encoding
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
    public static class AutoSDKShared56f06376e757011bDeliveryVariant1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared56f06376e757011bDeliveryVariant1Encoding value)
        {
            return value switch
            {
                AutoSDKShared56f06376e757011bDeliveryVariant1Encoding.Json => "json",
                AutoSDKShared56f06376e757011bDeliveryVariant1Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared56f06376e757011bDeliveryVariant1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKShared56f06376e757011bDeliveryVariant1Encoding.Json,
                "ndjson" => AutoSDKShared56f06376e757011bDeliveryVariant1Encoding.Ndjson,
                _ => null,
            };
        }
    }
}