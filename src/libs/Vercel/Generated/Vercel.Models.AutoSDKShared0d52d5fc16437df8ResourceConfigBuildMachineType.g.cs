
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType
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
    public static class AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}