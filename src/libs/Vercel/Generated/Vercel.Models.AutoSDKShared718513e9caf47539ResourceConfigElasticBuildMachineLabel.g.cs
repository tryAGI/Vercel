
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKShared718513e9caf47539ResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared718513e9caf47539ResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared718513e9caf47539ResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared718513e9caf47539ResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared718513e9caf47539ResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared718513e9caf47539ResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared718513e9caf47539ResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared718513e9caf47539ResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared718513e9caf47539ResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared718513e9caf47539ResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}