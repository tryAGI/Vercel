
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType
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
    public static class AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}