
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3e211e8bee7aaa5DeliveryStatsWindow
    {
        /// <summary>
        ///
        /// </summary>
        x24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda3e211e8bee7aaa5DeliveryStatsWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3e211e8bee7aaa5DeliveryStatsWindow value)
        {
            return value switch
            {
                AutoSDKShareda3e211e8bee7aaa5DeliveryStatsWindow.x24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3e211e8bee7aaa5DeliveryStatsWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => AutoSDKShareda3e211e8bee7aaa5DeliveryStatsWindow.x24h,
                _ => null,
            };
        }
    }
}