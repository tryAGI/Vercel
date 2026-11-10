
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared92580a598ccc210fDeliveryStatsState
    {
        /// <summary>
        ///
        /// </summary>
        Failing,
        /// <summary>
        ///
        /// </summary>
        Healthy,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared92580a598ccc210fDeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared92580a598ccc210fDeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShared92580a598ccc210fDeliveryStatsState.Failing => "failing",
                AutoSDKShared92580a598ccc210fDeliveryStatsState.Healthy => "healthy",
                AutoSDKShared92580a598ccc210fDeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared92580a598ccc210fDeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShared92580a598ccc210fDeliveryStatsState.Failing,
                "healthy" => AutoSDKShared92580a598ccc210fDeliveryStatsState.Healthy,
                "unknown" => AutoSDKShared92580a598ccc210fDeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}