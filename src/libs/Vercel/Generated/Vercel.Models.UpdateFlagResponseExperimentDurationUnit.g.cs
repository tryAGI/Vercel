
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseExperimentDurationUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Days,
        /// <summary>
        /// 
        /// </summary>
        Exposures,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseExperimentDurationUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseExperimentDurationUnit value)
        {
            return value switch
            {
                UpdateFlagResponseExperimentDurationUnit.Days => "days",
                UpdateFlagResponseExperimentDurationUnit.Exposures => "exposures",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseExperimentDurationUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => UpdateFlagResponseExperimentDurationUnit.Days,
                "exposures" => UpdateFlagResponseExperimentDurationUnit.Exposures,
                _ => null,
            };
        }
    }
}