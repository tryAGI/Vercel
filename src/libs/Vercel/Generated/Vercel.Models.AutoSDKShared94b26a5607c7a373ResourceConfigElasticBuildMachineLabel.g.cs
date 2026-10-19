
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373ResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared94b26a5607c7a373ResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373ResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373ResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared94b26a5607c7a373ResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared94b26a5607c7a373ResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373ResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared94b26a5607c7a373ResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared94b26a5607c7a373ResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared94b26a5607c7a373ResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}