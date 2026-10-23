
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType
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
    public static class AutoSDKShared52fb994527107e75ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared52fb994527107e75ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}