
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType
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
    public static class AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharede0e23f3391031fa6ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}