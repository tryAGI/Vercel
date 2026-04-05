
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChecksResponseCheckOutputMetricsTbtSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllChecksResponseCheckOutputMetricsTbtSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChecksResponseCheckOutputMetricsTbtSource value)
        {
            return value switch
            {
                GetAllChecksResponseCheckOutputMetricsTbtSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChecksResponseCheckOutputMetricsTbtSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => GetAllChecksResponseCheckOutputMetricsTbtSource.WebVitals,
                _ => null,
            };
        }
    }
}