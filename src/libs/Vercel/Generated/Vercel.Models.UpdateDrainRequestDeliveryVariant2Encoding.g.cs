
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainRequestDeliveryVariant2Encoding
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
    public static class UpdateDrainRequestDeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestDeliveryVariant2Encoding value)
        {
            return value switch
            {
                UpdateDrainRequestDeliveryVariant2Encoding.Json => "json",
                UpdateDrainRequestDeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestDeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => UpdateDrainRequestDeliveryVariant2Encoding.Json,
                "proto" => UpdateDrainRequestDeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}