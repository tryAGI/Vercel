
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2DeliveryVariant2Encoding
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
    public static class GetDrainResponseVariant2DeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2DeliveryVariant2Encoding value)
        {
            return value switch
            {
                GetDrainResponseVariant2DeliveryVariant2Encoding.Json => "json",
                GetDrainResponseVariant2DeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2DeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetDrainResponseVariant2DeliveryVariant2Encoding.Json,
                "proto" => GetDrainResponseVariant2DeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}