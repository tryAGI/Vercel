
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType
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
    public static class AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}