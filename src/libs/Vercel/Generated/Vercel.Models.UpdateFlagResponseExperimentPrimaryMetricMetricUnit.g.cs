
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseExperimentPrimaryMetricMetricUnit
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
    public static class UpdateFlagResponseExperimentPrimaryMetricMetricUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseExperimentPrimaryMetricMetricUnit value)
        {
            return value switch
            {
                UpdateFlagResponseExperimentPrimaryMetricMetricUnit.Session => "session",
                UpdateFlagResponseExperimentPrimaryMetricMetricUnit.User => "user",
                UpdateFlagResponseExperimentPrimaryMetricMetricUnit.Visitor => "visitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseExperimentPrimaryMetricMetricUnit? ToEnum(string value)
        {
            return value switch
            {
                "session" => UpdateFlagResponseExperimentPrimaryMetricMetricUnit.Session,
                "user" => UpdateFlagResponseExperimentPrimaryMetricMetricUnit.User,
                "visitor" => UpdateFlagResponseExperimentPrimaryMetricMetricUnit.Visitor,
                _ => null,
            };
        }
    }
}