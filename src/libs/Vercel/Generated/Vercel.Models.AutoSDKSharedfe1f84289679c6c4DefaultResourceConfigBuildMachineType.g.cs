
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}