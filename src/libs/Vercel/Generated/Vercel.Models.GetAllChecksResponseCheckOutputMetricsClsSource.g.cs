
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChecksResponseCheckOutputMetricsClsSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllChecksResponseCheckOutputMetricsClsSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChecksResponseCheckOutputMetricsClsSource value)
        {
            return value switch
            {
                GetAllChecksResponseCheckOutputMetricsClsSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChecksResponseCheckOutputMetricsClsSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => GetAllChecksResponseCheckOutputMetricsClsSource.WebVitals,
                _ => null,
            };
        }
    }
}