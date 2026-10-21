
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum GetProjectResponseDefaultResourceConfigElasticBuildMachineLabel
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
    public static class GetProjectResponseDefaultResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDefaultResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                GetProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                GetProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Standard => "standard",
                GetProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDefaultResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => GetProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => GetProjectResponseDefaultResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}