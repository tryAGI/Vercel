
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant1DeliveryVariant2Encoding
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
    public static class GetDrainResponseVariant1DeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant1DeliveryVariant2Encoding value)
        {
            return value switch
            {
                GetDrainResponseVariant1DeliveryVariant2Encoding.Json => "json",
                GetDrainResponseVariant1DeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant1DeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetDrainResponseVariant1DeliveryVariant2Encoding.Json,
                "proto" => GetDrainResponseVariant1DeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}