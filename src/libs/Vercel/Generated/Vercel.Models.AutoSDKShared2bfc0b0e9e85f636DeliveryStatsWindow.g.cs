
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2bfc0b0e9e85f636DeliveryStatsWindow
    {
        /// <summary>
        ///
        /// </summary>
        x24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2bfc0b0e9e85f636DeliveryStatsWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2bfc0b0e9e85f636DeliveryStatsWindow value)
        {
            return value switch
            {
                AutoSDKShared2bfc0b0e9e85f636DeliveryStatsWindow.x24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2bfc0b0e9e85f636DeliveryStatsWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => AutoSDKShared2bfc0b0e9e85f636DeliveryStatsWindow.x24h,
                _ => null,
            };
        }
    }
}