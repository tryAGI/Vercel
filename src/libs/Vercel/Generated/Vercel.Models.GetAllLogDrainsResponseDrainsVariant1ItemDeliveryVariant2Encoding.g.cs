
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding
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
    public static class GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding.Json => "json",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding.Json,
                "proto" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}