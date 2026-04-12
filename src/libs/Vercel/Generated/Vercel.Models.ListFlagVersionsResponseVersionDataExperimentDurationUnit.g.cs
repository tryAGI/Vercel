
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataExperimentDurationUnit
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
    public static class ListFlagVersionsResponseVersionDataExperimentDurationUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataExperimentDurationUnit value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataExperimentDurationUnit.Days => "days",
                ListFlagVersionsResponseVersionDataExperimentDurationUnit.Exposures => "exposures",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataExperimentDurationUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => ListFlagVersionsResponseVersionDataExperimentDurationUnit.Days,
                "exposures" => ListFlagVersionsResponseVersionDataExperimentDurationUnit.Exposures,
                _ => null,
            };
        }
    }
}