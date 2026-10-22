
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833DeliveryStatsState
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
    public static class AutoSDKShared6df91f8a45eab833DeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833DeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833DeliveryStatsState.Failing => "failing",
                AutoSDKShared6df91f8a45eab833DeliveryStatsState.Healthy => "healthy",
                AutoSDKShared6df91f8a45eab833DeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833DeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShared6df91f8a45eab833DeliveryStatsState.Failing,
                "healthy" => AutoSDKShared6df91f8a45eab833DeliveryStatsState.Healthy,
                "unknown" => AutoSDKShared6df91f8a45eab833DeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}