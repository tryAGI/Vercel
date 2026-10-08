
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKShared7851faacb4798d73DefaultResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared7851faacb4798d73DefaultResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7851faacb4798d73DefaultResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared7851faacb4798d73DefaultResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared7851faacb4798d73DefaultResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared7851faacb4798d73DefaultResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7851faacb4798d73DefaultResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared7851faacb4798d73DefaultResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared7851faacb4798d73DefaultResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared7851faacb4798d73DefaultResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}