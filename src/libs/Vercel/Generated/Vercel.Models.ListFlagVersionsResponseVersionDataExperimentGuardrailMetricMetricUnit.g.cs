
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Visitor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricUnit value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricUnit.Session => "session",
                ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricUnit.User => "user",
                ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricUnit.Visitor => "visitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricUnit? ToEnum(string value)
        {
            return value switch
            {
                "session" => ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricUnit.Session,
                "user" => ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricUnit.User,
                "visitor" => ListFlagVersionsResponseVersionDataExperimentGuardrailMetricMetricUnit.Visitor,
                _ => null,
            };
        }
    }
}