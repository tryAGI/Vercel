
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType
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
    public static class AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharede870b907cc1fb37eResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}