
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}