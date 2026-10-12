
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType
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
    public static class AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}