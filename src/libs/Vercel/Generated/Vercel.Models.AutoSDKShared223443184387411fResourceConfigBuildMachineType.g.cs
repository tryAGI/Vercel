
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared223443184387411fResourceConfigBuildMachineType
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
    public static class AutoSDKShared223443184387411fResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared223443184387411fResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared223443184387411fResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared223443184387411fResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared223443184387411fResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared223443184387411fResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared223443184387411fResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared223443184387411fResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared223443184387411fResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared223443184387411fResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared223443184387411fResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}