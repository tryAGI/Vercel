
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckResponseOutputMetricsLcpSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckResponseOutputMetricsLcpSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckResponseOutputMetricsLcpSource value)
        {
            return value switch
            {
                UpdateCheckResponseOutputMetricsLcpSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckResponseOutputMetricsLcpSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => UpdateCheckResponseOutputMetricsLcpSource.WebVitals,
                _ => null,
            };
        }
    }
}