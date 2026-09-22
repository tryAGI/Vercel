
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType
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
    public static class AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}