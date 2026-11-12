
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared90103a1814ebf3a8DeliveryStatsState
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
    public static class AutoSDKShared90103a1814ebf3a8DeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared90103a1814ebf3a8DeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShared90103a1814ebf3a8DeliveryStatsState.Failing => "failing",
                AutoSDKShared90103a1814ebf3a8DeliveryStatsState.Healthy => "healthy",
                AutoSDKShared90103a1814ebf3a8DeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared90103a1814ebf3a8DeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShared90103a1814ebf3a8DeliveryStatsState.Failing,
                "healthy" => AutoSDKShared90103a1814ebf3a8DeliveryStatsState.Healthy,
                "unknown" => AutoSDKShared90103a1814ebf3a8DeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}