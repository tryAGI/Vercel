
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType
    {
        /// <summary>
        ///
        /// </summary>
        Basic,
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
    public static class AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}