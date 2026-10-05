
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}