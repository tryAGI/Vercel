
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType
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
    public static class AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared8d2a365a5da335dfResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}