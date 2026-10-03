
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}