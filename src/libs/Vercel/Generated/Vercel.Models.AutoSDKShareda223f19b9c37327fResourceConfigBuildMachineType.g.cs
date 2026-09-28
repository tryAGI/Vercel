
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType
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
    public static class AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}