
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}