
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant1DeliveryVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainResponseVariant1DeliveryVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant1DeliveryVariant1Type value)
        {
            return value switch
            {
                GetDrainResponseVariant1DeliveryVariant1Type.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant1DeliveryVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "http" => GetDrainResponseVariant1DeliveryVariant1Type.Http,
                _ => null,
            };
        }
    }
}