
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2b02cf1378da97a7DeliveryStatsState
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
    public static class AutoSDKShared2b02cf1378da97a7DeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2b02cf1378da97a7DeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShared2b02cf1378da97a7DeliveryStatsState.Failing => "failing",
                AutoSDKShared2b02cf1378da97a7DeliveryStatsState.Healthy => "healthy",
                AutoSDKShared2b02cf1378da97a7DeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2b02cf1378da97a7DeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShared2b02cf1378da97a7DeliveryStatsState.Failing,
                "healthy" => AutoSDKShared2b02cf1378da97a7DeliveryStatsState.Healthy,
                "unknown" => AutoSDKShared2b02cf1378da97a7DeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}