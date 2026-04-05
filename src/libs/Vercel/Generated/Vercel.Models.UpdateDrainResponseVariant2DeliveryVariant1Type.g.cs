
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2DeliveryVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainResponseVariant2DeliveryVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2DeliveryVariant1Type value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2DeliveryVariant1Type.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2DeliveryVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "http" => UpdateDrainResponseVariant2DeliveryVariant1Type.Http,
                _ => null,
            };
        }
    }
}