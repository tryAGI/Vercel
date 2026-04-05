
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Otlphttp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2Type value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2Type.Otlphttp => "otlphttp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "otlphttp" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2Type.Otlphttp,
                _ => null,
            };
        }
    }
}