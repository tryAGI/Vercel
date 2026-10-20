
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}