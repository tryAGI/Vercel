
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType
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
    public static class AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}