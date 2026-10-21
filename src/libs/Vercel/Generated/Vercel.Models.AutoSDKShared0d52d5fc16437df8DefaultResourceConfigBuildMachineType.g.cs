
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}