
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType
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
    public static class ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType.Count => "count",
                ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType.Currency => "currency",
                ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType.Percentage => "percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType? ToEnum(string value)
        {
            return value switch
            {
                "count" => ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType.Count,
                "currency" => ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType.Currency,
                "percentage" => ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType.Percentage,
                _ => null,
            };
        }
    }
}