
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType
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
    public static class AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}