
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum AutoSDKShared52fb994527107e75ResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared52fb994527107e75ResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared52fb994527107e75ResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared52fb994527107e75ResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared52fb994527107e75ResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared52fb994527107e75ResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared52fb994527107e75ResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared52fb994527107e75ResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared52fb994527107e75ResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared52fb994527107e75ResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}