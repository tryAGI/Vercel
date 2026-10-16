
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}