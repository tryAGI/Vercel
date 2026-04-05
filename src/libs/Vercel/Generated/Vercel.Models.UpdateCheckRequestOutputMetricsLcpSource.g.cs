
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckRequestOutputMetricsLcpSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckRequestOutputMetricsLcpSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckRequestOutputMetricsLcpSource value)
        {
            return value switch
            {
                UpdateCheckRequestOutputMetricsLcpSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckRequestOutputMetricsLcpSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => UpdateCheckRequestOutputMetricsLcpSource.WebVitals,
                _ => null,
            };
        }
    }
}