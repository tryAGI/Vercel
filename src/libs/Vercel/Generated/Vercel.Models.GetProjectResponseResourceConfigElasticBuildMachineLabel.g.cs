
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum GetProjectResponseResourceConfigElasticBuildMachineLabel
    {
        /// <summary>
        ///
        /// </summary>
        Enhanced,
        /// <summary>
        ///
        /// </summary>
        Standard,
        /// <summary>
        ///
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                GetProjectResponseResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                GetProjectResponseResourceConfigElasticBuildMachineLabel.Standard => "standard",
                GetProjectResponseResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetProjectResponseResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => GetProjectResponseResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => GetProjectResponseResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}