
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCheckResponseOutputMetricsFcpSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCheckResponseOutputMetricsFcpSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCheckResponseOutputMetricsFcpSource value)
        {
            return value switch
            {
                CreateCheckResponseOutputMetricsFcpSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCheckResponseOutputMetricsFcpSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => CreateCheckResponseOutputMetricsFcpSource.WebVitals,
                _ => null,
            };
        }
    }
}