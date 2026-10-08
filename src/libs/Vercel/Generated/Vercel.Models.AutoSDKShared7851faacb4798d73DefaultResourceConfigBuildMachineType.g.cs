
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}