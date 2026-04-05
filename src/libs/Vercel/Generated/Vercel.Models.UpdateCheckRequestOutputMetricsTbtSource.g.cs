
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckRequestOutputMetricsTbtSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckRequestOutputMetricsTbtSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckRequestOutputMetricsTbtSource value)
        {
            return value switch
            {
                UpdateCheckRequestOutputMetricsTbtSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckRequestOutputMetricsTbtSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => UpdateCheckRequestOutputMetricsTbtSource.WebVitals,
                _ => null,
            };
        }
    }
}