
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}