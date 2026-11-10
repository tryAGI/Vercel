
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2bfc0b0e9e85f636DeliveryStatsState
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
    public static class AutoSDKShared2bfc0b0e9e85f636DeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2bfc0b0e9e85f636DeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShared2bfc0b0e9e85f636DeliveryStatsState.Failing => "failing",
                AutoSDKShared2bfc0b0e9e85f636DeliveryStatsState.Healthy => "healthy",
                AutoSDKShared2bfc0b0e9e85f636DeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2bfc0b0e9e85f636DeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShared2bfc0b0e9e85f636DeliveryStatsState.Failing,
                "healthy" => AutoSDKShared2bfc0b0e9e85f636DeliveryStatsState.Healthy,
                "unknown" => AutoSDKShared2bfc0b0e9e85f636DeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}