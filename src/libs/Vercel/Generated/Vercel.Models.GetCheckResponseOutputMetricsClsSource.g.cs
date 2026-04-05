
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCheckResponseOutputMetricsClsSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCheckResponseOutputMetricsClsSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCheckResponseOutputMetricsClsSource value)
        {
            return value switch
            {
                GetCheckResponseOutputMetricsClsSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCheckResponseOutputMetricsClsSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => GetCheckResponseOutputMetricsClsSource.WebVitals,
                _ => null,
            };
        }
    }
}