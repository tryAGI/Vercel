
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricType
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
    public static class ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricType value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricType.Count => "count",
                ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricType.Currency => "currency",
                ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricType.Percentage => "percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricType? ToEnum(string value)
        {
            return value switch
            {
                "count" => ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricType.Count,
                "currency" => ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricType.Currency,
                "percentage" => ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricType.Percentage,
                _ => null,
            };
        }
    }
}