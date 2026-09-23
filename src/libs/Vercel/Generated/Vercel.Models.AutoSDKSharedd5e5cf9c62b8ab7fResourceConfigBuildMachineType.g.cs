
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType
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
    public static class AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}