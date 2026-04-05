
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant1DeliveryVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Otlphttp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainResponseVariant1DeliveryVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1DeliveryVariant2Type value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1DeliveryVariant2Type.Otlphttp => "otlphttp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1DeliveryVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "otlphttp" => UpdateDrainResponseVariant1DeliveryVariant2Type.Otlphttp,
                _ => null,
            };
        }
    }
}