
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}