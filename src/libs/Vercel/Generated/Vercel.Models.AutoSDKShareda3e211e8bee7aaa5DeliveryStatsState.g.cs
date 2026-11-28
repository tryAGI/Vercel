
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3e211e8bee7aaa5DeliveryStatsState
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
    public static class AutoSDKShareda3e211e8bee7aaa5DeliveryStatsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3e211e8bee7aaa5DeliveryStatsState value)
        {
            return value switch
            {
                AutoSDKShareda3e211e8bee7aaa5DeliveryStatsState.Failing => "failing",
                AutoSDKShareda3e211e8bee7aaa5DeliveryStatsState.Healthy => "healthy",
                AutoSDKShareda3e211e8bee7aaa5DeliveryStatsState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3e211e8bee7aaa5DeliveryStatsState? ToEnum(string value)
        {
            return value switch
            {
                "failing" => AutoSDKShareda3e211e8bee7aaa5DeliveryStatsState.Failing,
                "healthy" => AutoSDKShareda3e211e8bee7aaa5DeliveryStatsState.Healthy,
                "unknown" => AutoSDKShareda3e211e8bee7aaa5DeliveryStatsState.Unknown,
                _ => null,
            };
        }
    }
}