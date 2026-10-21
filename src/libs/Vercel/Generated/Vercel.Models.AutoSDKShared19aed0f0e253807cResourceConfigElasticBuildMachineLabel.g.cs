
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum AutoSDKShared19aed0f0e253807cResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared19aed0f0e253807cResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared19aed0f0e253807cResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared19aed0f0e253807cResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared19aed0f0e253807cResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared19aed0f0e253807cResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared19aed0f0e253807cResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared19aed0f0e253807cResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared19aed0f0e253807cResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared19aed0f0e253807cResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}