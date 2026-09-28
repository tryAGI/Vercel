
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType
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
    public static class AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}