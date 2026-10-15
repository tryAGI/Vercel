
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKShared1006e75c11b11a21ResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared1006e75c11b11a21ResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1006e75c11b11a21ResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared1006e75c11b11a21ResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared1006e75c11b11a21ResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared1006e75c11b11a21ResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1006e75c11b11a21ResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared1006e75c11b11a21ResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared1006e75c11b11a21ResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared1006e75c11b11a21ResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}