
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseExperimentGuardrailMetricMetricType
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
    public static class UpdateFlagResponseExperimentGuardrailMetricMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseExperimentGuardrailMetricMetricType value)
        {
            return value switch
            {
                UpdateFlagResponseExperimentGuardrailMetricMetricType.Count => "count",
                UpdateFlagResponseExperimentGuardrailMetricMetricType.Currency => "currency",
                UpdateFlagResponseExperimentGuardrailMetricMetricType.Percentage => "percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseExperimentGuardrailMetricMetricType? ToEnum(string value)
        {
            return value switch
            {
                "count" => UpdateFlagResponseExperimentGuardrailMetricMetricType.Count,
                "currency" => UpdateFlagResponseExperimentGuardrailMetricMetricType.Currency,
                "percentage" => UpdateFlagResponseExperimentGuardrailMetricMetricType.Percentage,
                _ => null,
            };
        }
    }
}