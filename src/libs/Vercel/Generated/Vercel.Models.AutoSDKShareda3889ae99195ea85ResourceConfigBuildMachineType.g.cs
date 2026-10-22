
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType
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
    public static class AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShareda3889ae99195ea85ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}