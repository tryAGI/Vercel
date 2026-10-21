
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType
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
    public static class AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}