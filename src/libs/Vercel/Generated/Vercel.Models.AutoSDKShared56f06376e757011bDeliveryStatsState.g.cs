
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared56f06376e757011bDeliveryStatsState
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
    public static class AutoSDKShared56f06376e757011bDeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared56f06376e757011bDeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShared56f06376e757011bDeliveryStatsState.Failing => "failing",
                AutoSDKShared56f06376e757011bDeliveryStatsState.Healthy => "healthy",
                AutoSDKShared56f06376e757011bDeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared56f06376e757011bDeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShared56f06376e757011bDeliveryStatsState.Failing,
                "healthy" => AutoSDKShared56f06376e757011bDeliveryStatsState.Healthy,
                "unknown" => AutoSDKShared56f06376e757011bDeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}