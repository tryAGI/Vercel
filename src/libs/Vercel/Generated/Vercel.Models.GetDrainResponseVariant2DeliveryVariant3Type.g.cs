
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2DeliveryVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainResponseVariant2DeliveryVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2DeliveryVariant3Type value)
        {
            return value switch
            {
                GetDrainResponseVariant2DeliveryVariant3Type.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2DeliveryVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => GetDrainResponseVariant2DeliveryVariant3Type.Clickhouse,
                _ => null,
            };
        }
    }
}