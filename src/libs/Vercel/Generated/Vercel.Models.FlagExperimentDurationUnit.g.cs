
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagExperimentDurationUnit
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
    public static class FlagExperimentDurationUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagExperimentDurationUnit value)
        {
            return value switch
            {
                FlagExperimentDurationUnit.Days => "days",
                FlagExperimentDurationUnit.Exposures => "exposures",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagExperimentDurationUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => FlagExperimentDurationUnit.Days,
                "exposures" => FlagExperimentDurationUnit.Exposures,
                _ => null,
            };
        }
    }
}