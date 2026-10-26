
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341ResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared8b163ed62d2bb341ResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341ResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341ResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared8b163ed62d2bb341ResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared8b163ed62d2bb341ResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341ResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared8b163ed62d2bb341ResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared8b163ed62d2bb341ResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared8b163ed62d2bb341ResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}