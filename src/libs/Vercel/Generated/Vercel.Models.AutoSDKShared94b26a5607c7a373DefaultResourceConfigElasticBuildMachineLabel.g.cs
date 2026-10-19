
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}