
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Encoding
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
    public static class GetDrainsResponseDrainsVariant2ItemDeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Encoding value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Encoding.Json => "json",
                GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Encoding.Json,
                "proto" => GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}