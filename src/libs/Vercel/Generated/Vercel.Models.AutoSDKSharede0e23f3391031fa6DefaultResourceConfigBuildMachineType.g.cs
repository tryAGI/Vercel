
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}