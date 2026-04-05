
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckResponseOutputMetricsClsSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckResponseOutputMetricsClsSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckResponseOutputMetricsClsSource value)
        {
            return value switch
            {
                UpdateCheckResponseOutputMetricsClsSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckResponseOutputMetricsClsSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => UpdateCheckResponseOutputMetricsClsSource.WebVitals,
                _ => null,
            };
        }
    }
}