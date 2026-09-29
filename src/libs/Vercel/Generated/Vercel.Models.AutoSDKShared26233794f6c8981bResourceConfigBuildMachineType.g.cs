
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType
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
    public static class AutoSDKShared26233794f6c8981bResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared26233794f6c8981bResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}