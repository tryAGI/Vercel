
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseExperimentGuardrailMetricMetricUnit
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
    public static class UpdateFlagResponseExperimentGuardrailMetricMetricUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseExperimentGuardrailMetricMetricUnit value)
        {
            return value switch
            {
                UpdateFlagResponseExperimentGuardrailMetricMetricUnit.Session => "session",
                UpdateFlagResponseExperimentGuardrailMetricMetricUnit.User => "user",
                UpdateFlagResponseExperimentGuardrailMetricMetricUnit.Visitor => "visitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseExperimentGuardrailMetricMetricUnit? ToEnum(string value)
        {
            return value switch
            {
                "session" => UpdateFlagResponseExperimentGuardrailMetricMetricUnit.Session,
                "user" => UpdateFlagResponseExperimentGuardrailMetricMetricUnit.User,
                "visitor" => UpdateFlagResponseExperimentGuardrailMetricMetricUnit.Visitor,
                _ => null,
            };
        }
    }
}