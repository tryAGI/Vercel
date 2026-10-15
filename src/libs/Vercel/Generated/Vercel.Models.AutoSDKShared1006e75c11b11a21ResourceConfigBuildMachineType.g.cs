
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType
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
    public static class AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}