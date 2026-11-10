
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcDeliveryStatsState
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
    public static class AutoSDKShareda861c3cb40ec56dcDeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcDeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcDeliveryStatsState.Failing => "failing",
                AutoSDKShareda861c3cb40ec56dcDeliveryStatsState.Healthy => "healthy",
                AutoSDKShareda861c3cb40ec56dcDeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcDeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShareda861c3cb40ec56dcDeliveryStatsState.Failing,
                "healthy" => AutoSDKShareda861c3cb40ec56dcDeliveryStatsState.Healthy,
                "unknown" => AutoSDKShareda861c3cb40ec56dcDeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}