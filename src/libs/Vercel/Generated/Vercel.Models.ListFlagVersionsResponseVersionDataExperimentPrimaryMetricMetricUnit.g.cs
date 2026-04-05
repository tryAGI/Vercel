
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit
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
    public static class ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit.Session => "session",
                ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit.User => "user",
                ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit.Visitor => "visitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit? ToEnum(string value)
        {
            return value switch
            {
                "session" => ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit.Session,
                "user" => ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit.User,
                "visitor" => ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit.Visitor,
                _ => null,
            };
        }
    }
}