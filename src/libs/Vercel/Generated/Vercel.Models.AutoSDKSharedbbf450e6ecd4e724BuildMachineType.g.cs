
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbbf450e6ecd4e724BuildMachineType
    {
        /// <summary>
        ///
        /// </summary>
        x14cpu28gb,
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
    public static class AutoSDKSharedbbf450e6ecd4e724BuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbbf450e6ecd4e724BuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedbbf450e6ecd4e724BuildMachineType.x14cpu28gb => "14cpu-28gb",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineType.Basic => "basic",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineType.Standard => "standard",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbbf450e6ecd4e724BuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "14cpu-28gb" => AutoSDKSharedbbf450e6ecd4e724BuildMachineType.x14cpu28gb,
                "basic" => AutoSDKSharedbbf450e6ecd4e724BuildMachineType.Basic,
                "enhanced" => AutoSDKSharedbbf450e6ecd4e724BuildMachineType.Enhanced,
                "standard" => AutoSDKSharedbbf450e6ecd4e724BuildMachineType.Standard,
                "turbo" => AutoSDKSharedbbf450e6ecd4e724BuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}