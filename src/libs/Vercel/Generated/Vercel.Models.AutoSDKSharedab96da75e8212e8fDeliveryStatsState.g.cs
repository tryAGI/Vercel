
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab96da75e8212e8fDeliveryStatsState
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
    public static class AutoSDKSharedab96da75e8212e8fDeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab96da75e8212e8fDeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKSharedab96da75e8212e8fDeliveryStatsState.Failing => "failing",
                AutoSDKSharedab96da75e8212e8fDeliveryStatsState.Healthy => "healthy",
                AutoSDKSharedab96da75e8212e8fDeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab96da75e8212e8fDeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKSharedab96da75e8212e8fDeliveryStatsState.Failing,
                "healthy" => AutoSDKSharedab96da75e8212e8fDeliveryStatsState.Healthy,
                "unknown" => AutoSDKSharedab96da75e8212e8fDeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}