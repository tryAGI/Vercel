
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0001bb8e789a120eDeliveryStatsState
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
    public static class AutoSDKShared0001bb8e789a120eDeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0001bb8e789a120eDeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShared0001bb8e789a120eDeliveryStatsState.Failing => "failing",
                AutoSDKShared0001bb8e789a120eDeliveryStatsState.Healthy => "healthy",
                AutoSDKShared0001bb8e789a120eDeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0001bb8e789a120eDeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShared0001bb8e789a120eDeliveryStatsState.Failing,
                "healthy" => AutoSDKShared0001bb8e789a120eDeliveryStatsState.Healthy,
                "unknown" => AutoSDKShared0001bb8e789a120eDeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}