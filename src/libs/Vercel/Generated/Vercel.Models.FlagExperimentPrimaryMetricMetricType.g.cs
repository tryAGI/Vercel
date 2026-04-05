
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagExperimentPrimaryMetricMetricType
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
    public static class FlagExperimentPrimaryMetricMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagExperimentPrimaryMetricMetricType value)
        {
            return value switch
            {
                FlagExperimentPrimaryMetricMetricType.Count => "count",
                FlagExperimentPrimaryMetricMetricType.Currency => "currency",
                FlagExperimentPrimaryMetricMetricType.Percentage => "percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagExperimentPrimaryMetricMetricType? ToEnum(string value)
        {
            return value switch
            {
                "count" => FlagExperimentPrimaryMetricMetricType.Count,
                "currency" => FlagExperimentPrimaryMetricMetricType.Currency,
                "percentage" => FlagExperimentPrimaryMetricMetricType.Percentage,
                _ => null,
            };
        }
    }
}