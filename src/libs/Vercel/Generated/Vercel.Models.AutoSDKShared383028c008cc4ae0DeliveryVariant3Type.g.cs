
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0DeliveryVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0DeliveryVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0DeliveryVariant3Type value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0DeliveryVariant3Type.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0DeliveryVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => AutoSDKShared383028c008cc4ae0DeliveryVariant3Type.Clickhouse,
                _ => null,
            };
        }
    }
}