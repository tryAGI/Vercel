
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagExperimentPrimaryMetricMetricUnit
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
    public static class FlagExperimentPrimaryMetricMetricUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagExperimentPrimaryMetricMetricUnit value)
        {
            return value switch
            {
                FlagExperimentPrimaryMetricMetricUnit.Session => "session",
                FlagExperimentPrimaryMetricMetricUnit.User => "user",
                FlagExperimentPrimaryMetricMetricUnit.Visitor => "visitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagExperimentPrimaryMetricMetricUnit? ToEnum(string value)
        {
            return value switch
            {
                "session" => FlagExperimentPrimaryMetricMetricUnit.Session,
                "user" => FlagExperimentPrimaryMetricMetricUnit.User,
                "visitor" => FlagExperimentPrimaryMetricMetricUnit.Visitor,
                _ => null,
            };
        }
    }
}