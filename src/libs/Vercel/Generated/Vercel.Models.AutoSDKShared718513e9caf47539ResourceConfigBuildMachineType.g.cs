
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType
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
    public static class AutoSDKShared718513e9caf47539ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared718513e9caf47539ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}