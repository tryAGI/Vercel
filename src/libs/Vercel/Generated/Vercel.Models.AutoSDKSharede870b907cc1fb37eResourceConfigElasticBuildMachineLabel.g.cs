
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKSharede870b907cc1fb37eResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKSharede870b907cc1fb37eResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKSharede870b907cc1fb37eResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKSharede870b907cc1fb37eResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKSharede870b907cc1fb37eResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKSharede870b907cc1fb37eResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}