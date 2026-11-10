
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8DeliveryStatsState
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
    public static class AutoSDKShared8df5bff0bb4332b8DeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8DeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8DeliveryStatsState.Failing => "failing",
                AutoSDKShared8df5bff0bb4332b8DeliveryStatsState.Healthy => "healthy",
                AutoSDKShared8df5bff0bb4332b8DeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8DeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShared8df5bff0bb4332b8DeliveryStatsState.Failing,
                "healthy" => AutoSDKShared8df5bff0bb4332b8DeliveryStatsState.Healthy,
                "unknown" => AutoSDKShared8df5bff0bb4332b8DeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}