
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant2ItemDeliveryVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Type value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Type.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "http" => GetDrainsResponseDrainsVariant2ItemDeliveryVariant1Type.Http,
                _ => null,
            };
        }
    }
}