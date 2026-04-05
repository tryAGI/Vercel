
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagExperimentGuardrailMetricMetricType
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
    public static class FlagExperimentGuardrailMetricMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagExperimentGuardrailMetricMetricType value)
        {
            return value switch
            {
                FlagExperimentGuardrailMetricMetricType.Count => "count",
                FlagExperimentGuardrailMetricMetricType.Currency => "currency",
                FlagExperimentGuardrailMetricMetricType.Percentage => "percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagExperimentGuardrailMetricMetricType? ToEnum(string value)
        {
            return value switch
            {
                "count" => FlagExperimentGuardrailMetricMetricType.Count,
                "currency" => FlagExperimentGuardrailMetricMetricType.Currency,
                "percentage" => FlagExperimentGuardrailMetricMetricType.Percentage,
                _ => null,
            };
        }
    }
}