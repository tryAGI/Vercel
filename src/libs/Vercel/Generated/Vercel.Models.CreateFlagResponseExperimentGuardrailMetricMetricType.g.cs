
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseExperimentGuardrailMetricMetricType
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
    public static class CreateFlagResponseExperimentGuardrailMetricMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseExperimentGuardrailMetricMetricType value)
        {
            return value switch
            {
                CreateFlagResponseExperimentGuardrailMetricMetricType.Count => "count",
                CreateFlagResponseExperimentGuardrailMetricMetricType.Currency => "currency",
                CreateFlagResponseExperimentGuardrailMetricMetricType.Percentage => "percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseExperimentGuardrailMetricMetricType? ToEnum(string value)
        {
            return value switch
            {
                "count" => CreateFlagResponseExperimentGuardrailMetricMetricType.Count,
                "currency" => CreateFlagResponseExperimentGuardrailMetricMetricType.Currency,
                "percentage" => CreateFlagResponseExperimentGuardrailMetricMetricType.Percentage,
                _ => null,
            };
        }
    }
}