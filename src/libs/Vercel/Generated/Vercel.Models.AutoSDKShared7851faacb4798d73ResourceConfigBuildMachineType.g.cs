
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType
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
    public static class AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared7851faacb4798d73ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}