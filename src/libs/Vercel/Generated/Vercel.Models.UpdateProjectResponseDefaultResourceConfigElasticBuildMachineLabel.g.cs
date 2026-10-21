
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum UpdateProjectResponseDefaultResourceConfigElasticBuildMachineLabel
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
    public static class UpdateProjectResponseDefaultResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDefaultResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                UpdateProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                UpdateProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Standard => "standard",
                UpdateProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDefaultResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UpdateProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => UpdateProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => UpdateProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}