
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}