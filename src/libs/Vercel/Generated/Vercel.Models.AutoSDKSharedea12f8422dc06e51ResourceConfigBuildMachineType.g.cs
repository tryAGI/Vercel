
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType
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
    public static class AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}