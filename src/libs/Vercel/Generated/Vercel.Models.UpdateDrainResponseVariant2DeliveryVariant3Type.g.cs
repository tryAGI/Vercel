
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2DeliveryVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainResponseVariant2DeliveryVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2DeliveryVariant3Type value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2DeliveryVariant3Type.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2DeliveryVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => UpdateDrainResponseVariant2DeliveryVariant3Type.Clickhouse,
                _ => null,
            };
        }
    }
}