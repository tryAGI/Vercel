
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChecksResponseCheckOutputMetricsLcpSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllChecksResponseCheckOutputMetricsLcpSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChecksResponseCheckOutputMetricsLcpSource value)
        {
            return value switch
            {
                GetAllChecksResponseCheckOutputMetricsLcpSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChecksResponseCheckOutputMetricsLcpSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => GetAllChecksResponseCheckOutputMetricsLcpSource.WebVitals,
                _ => null,
            };
        }
    }
}