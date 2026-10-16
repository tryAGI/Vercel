
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType
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
    public static class AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}