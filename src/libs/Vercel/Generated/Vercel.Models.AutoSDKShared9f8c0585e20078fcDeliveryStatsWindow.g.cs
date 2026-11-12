
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9f8c0585e20078fcDeliveryStatsWindow
    {
        /// <summary>
        ///
        /// </summary>
        x24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9f8c0585e20078fcDeliveryStatsWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9f8c0585e20078fcDeliveryStatsWindow value)
        {
            return value switch
            {
                AutoSDKShared9f8c0585e20078fcDeliveryStatsWindow.x24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9f8c0585e20078fcDeliveryStatsWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => AutoSDKShared9f8c0585e20078fcDeliveryStatsWindow.x24h,
                _ => null,
            };
        }
    }
}