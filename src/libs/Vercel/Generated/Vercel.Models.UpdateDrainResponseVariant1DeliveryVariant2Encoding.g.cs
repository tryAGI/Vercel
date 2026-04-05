
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant1DeliveryVariant2Encoding
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
    public static class UpdateDrainResponseVariant1DeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1DeliveryVariant2Encoding value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1DeliveryVariant2Encoding.Json => "json",
                UpdateDrainResponseVariant1DeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1DeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => UpdateDrainResponseVariant1DeliveryVariant2Encoding.Json,
                "proto" => UpdateDrainResponseVariant1DeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}