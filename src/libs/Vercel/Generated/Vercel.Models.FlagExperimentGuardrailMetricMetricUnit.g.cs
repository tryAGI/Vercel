
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagExperimentGuardrailMetricMetricUnit
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
    public static class FlagExperimentGuardrailMetricMetricUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagExperimentGuardrailMetricMetricUnit value)
        {
            return value switch
            {
                FlagExperimentGuardrailMetricMetricUnit.Session => "session",
                FlagExperimentGuardrailMetricMetricUnit.User => "user",
                FlagExperimentGuardrailMetricMetricUnit.Visitor => "visitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagExperimentGuardrailMetricMetricUnit? ToEnum(string value)
        {
            return value switch
            {
                "session" => FlagExperimentGuardrailMetricMetricUnit.Session,
                "user" => FlagExperimentGuardrailMetricMetricUnit.User,
                "visitor" => FlagExperimentGuardrailMetricMetricUnit.Visitor,
                _ => null,
            };
        }
    }
}