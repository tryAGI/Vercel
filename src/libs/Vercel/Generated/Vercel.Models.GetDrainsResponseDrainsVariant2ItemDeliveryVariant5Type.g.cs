
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemDeliveryVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant2ItemDeliveryVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemDeliveryVariant5Type value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemDeliveryVariant5Type.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemDeliveryVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "internal" => GetDrainsResponseDrainsVariant2ItemDeliveryVariant5Type.Internal,
                _ => null,
            };
        }
    }
}