
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType
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
    public static class AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKShareddf9dcf09167540b7ResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}