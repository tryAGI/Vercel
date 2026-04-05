
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2DeliveryVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Otlphttp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainResponseVariant2DeliveryVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2DeliveryVariant2Type value)
        {
            return value switch
            {
                GetDrainResponseVariant2DeliveryVariant2Type.Otlphttp => "otlphttp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2DeliveryVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "otlphttp" => GetDrainResponseVariant2DeliveryVariant2Type.Otlphttp,
                _ => null,
            };
        }
    }
}