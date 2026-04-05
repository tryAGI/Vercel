
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckRequestOutputMetricsVirtualExperienceScoreSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckRequestOutputMetricsVirtualExperienceScoreSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckRequestOutputMetricsVirtualExperienceScoreSource value)
        {
            return value switch
            {
                UpdateCheckRequestOutputMetricsVirtualExperienceScoreSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckRequestOutputMetricsVirtualExperienceScoreSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => UpdateCheckRequestOutputMetricsVirtualExperienceScoreSource.WebVitals,
                _ => null,
            };
        }
    }
}