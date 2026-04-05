
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseExperimentPrimaryMetricMetricUnit
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
    public static class CreateFlagResponseExperimentPrimaryMetricMetricUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseExperimentPrimaryMetricMetricUnit value)
        {
            return value switch
            {
                CreateFlagResponseExperimentPrimaryMetricMetricUnit.Session => "session",
                CreateFlagResponseExperimentPrimaryMetricMetricUnit.User => "user",
                CreateFlagResponseExperimentPrimaryMetricMetricUnit.Visitor => "visitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseExperimentPrimaryMetricMetricUnit? ToEnum(string value)
        {
            return value switch
            {
                "session" => CreateFlagResponseExperimentPrimaryMetricMetricUnit.Session,
                "user" => CreateFlagResponseExperimentPrimaryMetricMetricUnit.User,
                "visitor" => CreateFlagResponseExperimentPrimaryMetricMetricUnit.Visitor,
                _ => null,
            };
        }
    }
}