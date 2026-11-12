
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared90103a1814ebf3a8DeliveryStatsWindow
    {
        /// <summary>
        ///
        /// </summary>
        x24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared90103a1814ebf3a8DeliveryStatsWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared90103a1814ebf3a8DeliveryStatsWindow value)
        {
            return value switch
            {
                AutoSDKShared90103a1814ebf3a8DeliveryStatsWindow.x24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared90103a1814ebf3a8DeliveryStatsWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => AutoSDKShared90103a1814ebf3a8DeliveryStatsWindow.x24h,
                _ => null,
            };
        }
    }
}