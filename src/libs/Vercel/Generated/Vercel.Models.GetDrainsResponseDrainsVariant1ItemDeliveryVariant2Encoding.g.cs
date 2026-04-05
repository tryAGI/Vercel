
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding
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
    public static class GetDrainsResponseDrainsVariant1ItemDeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding.Json => "json",
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding.Json,
                "proto" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}