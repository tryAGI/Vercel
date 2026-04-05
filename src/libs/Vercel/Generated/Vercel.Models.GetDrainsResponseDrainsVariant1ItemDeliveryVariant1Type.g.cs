
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant1ItemDeliveryVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Type value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Type.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "http" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant1Type.Http,
                _ => null,
            };
        }
    }
}