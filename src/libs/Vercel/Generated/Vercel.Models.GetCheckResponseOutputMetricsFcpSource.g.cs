
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCheckResponseOutputMetricsFcpSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCheckResponseOutputMetricsFcpSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCheckResponseOutputMetricsFcpSource value)
        {
            return value switch
            {
                GetCheckResponseOutputMetricsFcpSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCheckResponseOutputMetricsFcpSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => GetCheckResponseOutputMetricsFcpSource.WebVitals,
                _ => null,
            };
        }
    }
}