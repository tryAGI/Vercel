
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCheckResponseOutputMetricsLcpSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCheckResponseOutputMetricsLcpSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCheckResponseOutputMetricsLcpSource value)
        {
            return value switch
            {
                CreateCheckResponseOutputMetricsLcpSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCheckResponseOutputMetricsLcpSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => CreateCheckResponseOutputMetricsLcpSource.WebVitals,
                _ => null,
            };
        }
    }
}