
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85DefaultResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShareda3889ae99195ea85DefaultResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85DefaultResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85DefaultResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}