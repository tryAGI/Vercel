
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Encoding
    {
        /// <summary>
        ///
        /// </summary>
        Json,
        /// <summary>
        ///
        /// </summary>
        Proto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8df5bff0bb4332b8DeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Encoding value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Encoding.Json => "json",
                AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Encoding.Json,
                "proto" => AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}