
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckRequestOutputMetricsClsSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckRequestOutputMetricsClsSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckRequestOutputMetricsClsSource value)
        {
            return value switch
            {
                UpdateCheckRequestOutputMetricsClsSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckRequestOutputMetricsClsSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => UpdateCheckRequestOutputMetricsClsSource.WebVitals,
                _ => null,
            };
        }
    }
}