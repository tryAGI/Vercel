
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType
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
    public static class AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}