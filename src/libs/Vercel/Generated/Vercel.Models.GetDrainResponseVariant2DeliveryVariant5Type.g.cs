
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2DeliveryVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainResponseVariant2DeliveryVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2DeliveryVariant5Type value)
        {
            return value switch
            {
                GetDrainResponseVariant2DeliveryVariant5Type.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2DeliveryVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "internal" => GetDrainResponseVariant2DeliveryVariant5Type.Internal,
                _ => null,
            };
        }
    }
}