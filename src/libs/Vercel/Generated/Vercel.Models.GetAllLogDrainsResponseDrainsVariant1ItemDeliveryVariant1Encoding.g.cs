
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding
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
    public static class GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding.Json => "json",
                GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding.Json,
                "ndjson" => GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant1Encoding.Ndjson,
                _ => null,
            };
        }
    }
}