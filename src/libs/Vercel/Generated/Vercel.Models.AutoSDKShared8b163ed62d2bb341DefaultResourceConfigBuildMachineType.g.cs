
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}