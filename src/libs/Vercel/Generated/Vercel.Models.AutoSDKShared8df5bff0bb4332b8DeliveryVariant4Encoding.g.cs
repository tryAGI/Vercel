
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Encoding
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
    public static class AutoSDKShared8df5bff0bb4332b8DeliveryVariant4EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Encoding value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Encoding.Json => "json",
                AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Encoding.Json,
                "ndjson" => AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Encoding.Ndjson,
                _ => null,
            };
        }
    }
}