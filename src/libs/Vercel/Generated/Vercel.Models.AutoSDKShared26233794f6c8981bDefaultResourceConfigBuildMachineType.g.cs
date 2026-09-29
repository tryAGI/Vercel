
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}