
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}