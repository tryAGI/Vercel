
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab96da75e8212e8fDeliveryStatsWindow
    {
        /// <summary>
        ///
        /// </summary>
        x24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedab96da75e8212e8fDeliveryStatsWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab96da75e8212e8fDeliveryStatsWindow value)
        {
            return value switch
            {
                AutoSDKSharedab96da75e8212e8fDeliveryStatsWindow.x24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab96da75e8212e8fDeliveryStatsWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => AutoSDKSharedab96da75e8212e8fDeliveryStatsWindow.x24h,
                _ => null,
            };
        }
    }
}