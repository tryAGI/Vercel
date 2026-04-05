
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Type value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Type.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "http" => GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Type.Http,
                _ => null,
            };
        }
    }
}