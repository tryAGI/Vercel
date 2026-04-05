
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChecksResponseCheckOutputMetricsVirtualExperienceScoreSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllChecksResponseCheckOutputMetricsVirtualExperienceScoreSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChecksResponseCheckOutputMetricsVirtualExperienceScoreSource value)
        {
            return value switch
            {
                GetAllChecksResponseCheckOutputMetricsVirtualExperienceScoreSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChecksResponseCheckOutputMetricsVirtualExperienceScoreSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => GetAllChecksResponseCheckOutputMetricsVirtualExperienceScoreSource.WebVitals,
                _ => null,
            };
        }
    }
}