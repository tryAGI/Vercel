
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType
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
    public static class AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharede870b907cc1fb37eDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}