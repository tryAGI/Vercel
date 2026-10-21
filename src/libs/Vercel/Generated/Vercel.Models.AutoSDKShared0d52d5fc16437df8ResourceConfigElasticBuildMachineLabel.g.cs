
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8ResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared0d52d5fc16437df8ResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8ResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8ResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared0d52d5fc16437df8ResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared0d52d5fc16437df8ResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8ResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared0d52d5fc16437df8ResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared0d52d5fc16437df8ResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared0d52d5fc16437df8ResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}