
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType
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
    public static class AutoSDKShared949b4255932cb64aResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared949b4255932cb64aResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}