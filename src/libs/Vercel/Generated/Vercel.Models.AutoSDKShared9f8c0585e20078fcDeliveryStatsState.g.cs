
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9f8c0585e20078fcDeliveryStatsState
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
    public static class AutoSDKShared9f8c0585e20078fcDeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9f8c0585e20078fcDeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShared9f8c0585e20078fcDeliveryStatsState.Failing => "failing",
                AutoSDKShared9f8c0585e20078fcDeliveryStatsState.Healthy => "healthy",
                AutoSDKShared9f8c0585e20078fcDeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9f8c0585e20078fcDeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShared9f8c0585e20078fcDeliveryStatsState.Failing,
                "healthy" => AutoSDKShared9f8c0585e20078fcDeliveryStatsState.Healthy,
                "unknown" => AutoSDKShared9f8c0585e20078fcDeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}