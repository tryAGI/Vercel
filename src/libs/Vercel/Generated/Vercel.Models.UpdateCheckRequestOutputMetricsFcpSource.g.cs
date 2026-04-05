
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckRequestOutputMetricsFcpSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckRequestOutputMetricsFcpSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckRequestOutputMetricsFcpSource value)
        {
            return value switch
            {
                UpdateCheckRequestOutputMetricsFcpSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckRequestOutputMetricsFcpSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => UpdateCheckRequestOutputMetricsFcpSource.WebVitals,
                _ => null,
            };
        }
    }
}