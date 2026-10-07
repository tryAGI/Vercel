
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared223443184387411fDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}