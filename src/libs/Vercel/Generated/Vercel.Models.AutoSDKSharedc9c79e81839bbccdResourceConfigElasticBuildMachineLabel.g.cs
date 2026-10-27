
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKSharedc9c79e81839bbccdResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKSharedc9c79e81839bbccdResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKSharedc9c79e81839bbccdResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKSharedc9c79e81839bbccdResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKSharedc9c79e81839bbccdResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKSharedc9c79e81839bbccdResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}