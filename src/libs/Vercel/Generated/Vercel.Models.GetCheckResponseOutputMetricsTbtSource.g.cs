
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCheckResponseOutputMetricsTbtSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCheckResponseOutputMetricsTbtSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCheckResponseOutputMetricsTbtSource value)
        {
            return value switch
            {
                GetCheckResponseOutputMetricsTbtSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCheckResponseOutputMetricsTbtSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => GetCheckResponseOutputMetricsTbtSource.WebVitals,
                _ => null,
            };
        }
    }
}