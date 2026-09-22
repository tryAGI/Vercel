
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Event type - must be "schedule/v1beta" (REQUIRED)
    /// </summary>
    public enum AutoSDKShareda0db2c4b058f2749Variant3Type
    {
        /// <summary>
        ///
        /// </summary>
        ScheduleV1beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda0db2c4b058f2749Variant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda0db2c4b058f2749Variant3Type value)
        {
            return value switch
            {
                AutoSDKShareda0db2c4b058f2749Variant3Type.ScheduleV1beta => "schedule/v1beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda0db2c4b058f2749Variant3Type? ToEnum(string value)
        {
            return value switch
            {
                "schedule/v1beta" => AutoSDKShareda0db2c4b058f2749Variant3Type.ScheduleV1beta,
                _ => null,
            };
        }
    }
}