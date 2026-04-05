
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseExperimentPrimaryMetricMetricType
    {
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        Currency,
        /// <summary>
        /// 
        /// </summary>
        Percentage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseExperimentPrimaryMetricMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseExperimentPrimaryMetricMetricType value)
        {
            return value switch
            {
                UpdateFlagResponseExperimentPrimaryMetricMetricType.Count => "count",
                UpdateFlagResponseExperimentPrimaryMetricMetricType.Currency => "currency",
                UpdateFlagResponseExperimentPrimaryMetricMetricType.Percentage => "percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseExperimentPrimaryMetricMetricType? ToEnum(string value)
        {
            return value switch
            {
                "count" => UpdateFlagResponseExperimentPrimaryMetricMetricType.Count,
                "currency" => UpdateFlagResponseExperimentPrimaryMetricMetricType.Currency,
                "percentage" => UpdateFlagResponseExperimentPrimaryMetricMetricType.Percentage,
                _ => null,
            };
        }
    }
}