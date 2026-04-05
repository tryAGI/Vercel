
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckResponseOutputMetricsVirtualExperienceScoreSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckResponseOutputMetricsVirtualExperienceScoreSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckResponseOutputMetricsVirtualExperienceScoreSource value)
        {
            return value switch
            {
                UpdateCheckResponseOutputMetricsVirtualExperienceScoreSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckResponseOutputMetricsVirtualExperienceScoreSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => UpdateCheckResponseOutputMetricsVirtualExperienceScoreSource.WebVitals,
                _ => null,
            };
        }
    }
}