
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectResourceConfigElasticBuildMachineLabel
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
    public static class GetMicrofrontendsInGroupResponseProjectResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                GetMicrofrontendsInGroupResponseProjectResourceConfigElasticBuildMachineLabel.Standard => "standard",
                GetMicrofrontendsInGroupResponseProjectResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetMicrofrontendsInGroupResponseProjectResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => GetMicrofrontendsInGroupResponseProjectResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => GetMicrofrontendsInGroupResponseProjectResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}