
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341DefaultResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared8b163ed62d2bb341DefaultResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341DefaultResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341DefaultResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared8b163ed62d2bb341DefaultResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared8b163ed62d2bb341DefaultResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341DefaultResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared8b163ed62d2bb341DefaultResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared8b163ed62d2bb341DefaultResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared8b163ed62d2bb341DefaultResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}