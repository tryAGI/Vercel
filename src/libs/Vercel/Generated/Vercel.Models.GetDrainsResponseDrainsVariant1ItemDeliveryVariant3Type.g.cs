
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemDeliveryVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant1ItemDeliveryVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemDeliveryVariant3Type value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant3Type.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemDeliveryVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant3Type.Clickhouse,
                _ => null,
            };
        }
    }
}