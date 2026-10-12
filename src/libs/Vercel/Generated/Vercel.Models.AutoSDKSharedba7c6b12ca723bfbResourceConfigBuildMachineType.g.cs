
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType
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
    public static class AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}