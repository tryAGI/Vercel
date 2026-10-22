
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217DeliveryStatsState
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
    public static class AutoSDKShared0695a89a4e02b217DeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217DeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217DeliveryStatsState.Failing => "failing",
                AutoSDKShared0695a89a4e02b217DeliveryStatsState.Healthy => "healthy",
                AutoSDKShared0695a89a4e02b217DeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217DeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShared0695a89a4e02b217DeliveryStatsState.Failing,
                "healthy" => AutoSDKShared0695a89a4e02b217DeliveryStatsState.Healthy,
                "unknown" => AutoSDKShared0695a89a4e02b217DeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}