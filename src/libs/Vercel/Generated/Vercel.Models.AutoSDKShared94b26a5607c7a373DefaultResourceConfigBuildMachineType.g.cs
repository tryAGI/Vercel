
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}