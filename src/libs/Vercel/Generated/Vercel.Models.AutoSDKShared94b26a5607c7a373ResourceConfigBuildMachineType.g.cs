
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType
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
    public static class AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}