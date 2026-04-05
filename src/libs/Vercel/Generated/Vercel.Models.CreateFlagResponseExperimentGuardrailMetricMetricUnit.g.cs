
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseExperimentGuardrailMetricMetricUnit
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
    public static class CreateFlagResponseExperimentGuardrailMetricMetricUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseExperimentGuardrailMetricMetricUnit value)
        {
            return value switch
            {
                CreateFlagResponseExperimentGuardrailMetricMetricUnit.Session => "session",
                CreateFlagResponseExperimentGuardrailMetricMetricUnit.User => "user",
                CreateFlagResponseExperimentGuardrailMetricMetricUnit.Visitor => "visitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseExperimentGuardrailMetricMetricUnit? ToEnum(string value)
        {
            return value switch
            {
                "session" => CreateFlagResponseExperimentGuardrailMetricMetricUnit.Session,
                "user" => CreateFlagResponseExperimentGuardrailMetricMetricUnit.User,
                "visitor" => CreateFlagResponseExperimentGuardrailMetricMetricUnit.Visitor,
                _ => null,
            };
        }
    }
}