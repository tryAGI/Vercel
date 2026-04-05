
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCheckResponseOutputMetricsLcpSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCheckResponseOutputMetricsLcpSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCheckResponseOutputMetricsLcpSource value)
        {
            return value switch
            {
                GetCheckResponseOutputMetricsLcpSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCheckResponseOutputMetricsLcpSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => GetCheckResponseOutputMetricsLcpSource.WebVitals,
                _ => null,
            };
        }
    }
}