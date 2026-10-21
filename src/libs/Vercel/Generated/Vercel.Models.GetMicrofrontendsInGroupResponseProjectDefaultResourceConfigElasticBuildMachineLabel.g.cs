
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigElasticBuildMachineLabel
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
    public static class GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigElasticBuildMachineLabel.Standard => "standard",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}