
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType
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
    public static class AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharede052f139ff613de3ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}