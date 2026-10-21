
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum UpdateProjectResponseResourceConfigElasticBuildMachineLabel
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
    public static class UpdateProjectResponseResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                UpdateProjectResponseResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                UpdateProjectResponseResourceConfigElasticBuildMachineLabel.Standard => "standard",
                UpdateProjectResponseResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UpdateProjectResponseResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => UpdateProjectResponseResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => UpdateProjectResponseResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}