
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseExperimentPrimaryMetricMetricType
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
    public static class CreateFlagResponseExperimentPrimaryMetricMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseExperimentPrimaryMetricMetricType value)
        {
            return value switch
            {
                CreateFlagResponseExperimentPrimaryMetricMetricType.Count => "count",
                CreateFlagResponseExperimentPrimaryMetricMetricType.Currency => "currency",
                CreateFlagResponseExperimentPrimaryMetricMetricType.Percentage => "percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseExperimentPrimaryMetricMetricType? ToEnum(string value)
        {
            return value switch
            {
                "count" => CreateFlagResponseExperimentPrimaryMetricMetricType.Count,
                "currency" => CreateFlagResponseExperimentPrimaryMetricMetricType.Currency,
                "percentage" => CreateFlagResponseExperimentPrimaryMetricMetricType.Percentage,
                _ => null,
            };
        }
    }
}