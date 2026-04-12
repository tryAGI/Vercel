
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseExperimentDurationUnit
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
    public static class CreateFlagResponseExperimentDurationUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseExperimentDurationUnit value)
        {
            return value switch
            {
                CreateFlagResponseExperimentDurationUnit.Days => "days",
                CreateFlagResponseExperimentDurationUnit.Exposures => "exposures",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseExperimentDurationUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => CreateFlagResponseExperimentDurationUnit.Days,
                "exposures" => CreateFlagResponseExperimentDurationUnit.Exposures,
                _ => null,
            };
        }
    }
}