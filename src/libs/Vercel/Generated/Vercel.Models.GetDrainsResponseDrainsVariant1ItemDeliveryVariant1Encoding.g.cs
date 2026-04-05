
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding
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
    public static class GetDrainsResponseDrainsVariant1ItemDeliveryVariant1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding.Json => "json",
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding.Json,
                "ndjson" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding.Ndjson,
                _ => null,
            };
        }
    }
}