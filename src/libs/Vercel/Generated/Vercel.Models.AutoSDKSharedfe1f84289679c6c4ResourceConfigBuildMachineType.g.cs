
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType
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
    public static class AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}