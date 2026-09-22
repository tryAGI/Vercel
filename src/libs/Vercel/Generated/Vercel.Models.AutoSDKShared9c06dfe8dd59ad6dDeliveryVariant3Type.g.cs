
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant3Type value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant3Type.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant3Type.Clickhouse,
                _ => null,
            };
        }
    }
}