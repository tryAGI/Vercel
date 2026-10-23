
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared52fb994527107e75DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}