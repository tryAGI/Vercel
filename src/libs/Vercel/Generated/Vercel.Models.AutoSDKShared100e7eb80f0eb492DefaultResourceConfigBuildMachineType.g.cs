
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared100e7eb80f0eb492DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}