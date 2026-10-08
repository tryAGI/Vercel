
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType
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
    public static class AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedb2df422af367f681ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}