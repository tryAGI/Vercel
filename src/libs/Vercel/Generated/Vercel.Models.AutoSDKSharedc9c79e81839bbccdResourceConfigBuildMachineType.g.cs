
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType
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
    public static class AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}