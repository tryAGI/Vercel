
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCheckResponseOutputMetricsVirtualExperienceScoreSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCheckResponseOutputMetricsVirtualExperienceScoreSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCheckResponseOutputMetricsVirtualExperienceScoreSource value)
        {
            return value switch
            {
                GetCheckResponseOutputMetricsVirtualExperienceScoreSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCheckResponseOutputMetricsVirtualExperienceScoreSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => GetCheckResponseOutputMetricsVirtualExperienceScoreSource.WebVitals,
                _ => null,
            };
        }
    }
}