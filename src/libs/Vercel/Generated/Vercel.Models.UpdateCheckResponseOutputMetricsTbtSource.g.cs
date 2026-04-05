
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckResponseOutputMetricsTbtSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckResponseOutputMetricsTbtSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckResponseOutputMetricsTbtSource value)
        {
            return value switch
            {
                UpdateCheckResponseOutputMetricsTbtSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckResponseOutputMetricsTbtSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => UpdateCheckResponseOutputMetricsTbtSource.WebVitals,
                _ => null,
            };
        }
    }
}