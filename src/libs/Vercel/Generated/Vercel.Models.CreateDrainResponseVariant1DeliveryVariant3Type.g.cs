
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant1DeliveryVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainResponseVariant1DeliveryVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant1DeliveryVariant3Type value)
        {
            return value switch
            {
                CreateDrainResponseVariant1DeliveryVariant3Type.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant1DeliveryVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => CreateDrainResponseVariant1DeliveryVariant3Type.Clickhouse,
                _ => null,
            };
        }
    }
}