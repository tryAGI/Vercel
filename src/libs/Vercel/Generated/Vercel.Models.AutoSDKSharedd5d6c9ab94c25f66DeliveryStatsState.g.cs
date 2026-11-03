
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66DeliveryStatsState
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
    public static class AutoSDKSharedd5d6c9ab94c25f66DeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66DeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66DeliveryStatsState.Failing => "failing",
                AutoSDKSharedd5d6c9ab94c25f66DeliveryStatsState.Healthy => "healthy",
                AutoSDKSharedd5d6c9ab94c25f66DeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66DeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKSharedd5d6c9ab94c25f66DeliveryStatsState.Failing,
                "healthy" => AutoSDKSharedd5d6c9ab94c25f66DeliveryStatsState.Healthy,
                "unknown" => AutoSDKSharedd5d6c9ab94c25f66DeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}