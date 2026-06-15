
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Encoding
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
    public static class GetDrainsResponseDrainsVariant2ItemDeliveryVariant4EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Encoding value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Encoding.Json => "json",
                GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Encoding.Json,
                "ndjson" => GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Encoding.Ndjson,
                _ => null,
            };
        }
    }
}