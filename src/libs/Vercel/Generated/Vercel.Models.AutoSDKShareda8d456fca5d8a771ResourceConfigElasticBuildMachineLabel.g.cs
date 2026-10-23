
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
    /// </summary>
    public enum AutoSDKShareda8d456fca5d8a771ResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShareda8d456fca5d8a771ResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda8d456fca5d8a771ResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShareda8d456fca5d8a771ResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShareda8d456fca5d8a771ResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShareda8d456fca5d8a771ResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda8d456fca5d8a771ResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShareda8d456fca5d8a771ResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShareda8d456fca5d8a771ResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShareda8d456fca5d8a771ResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}