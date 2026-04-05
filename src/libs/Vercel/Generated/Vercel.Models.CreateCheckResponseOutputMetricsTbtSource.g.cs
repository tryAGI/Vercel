
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCheckResponseOutputMetricsTbtSource
    {
        /// <summary>
        /// 
        /// </summary>
        WebVitals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCheckResponseOutputMetricsTbtSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCheckResponseOutputMetricsTbtSource value)
        {
            return value switch
            {
                CreateCheckResponseOutputMetricsTbtSource.WebVitals => "web-vitals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCheckResponseOutputMetricsTbtSource? ToEnum(string value)
        {
            return value switch
            {
                "web-vitals" => CreateCheckResponseOutputMetricsTbtSource.WebVitals,
                _ => null,
            };
        }
    }
}