
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType
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
    public static class AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}