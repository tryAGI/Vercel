
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectResourceConfigBuildMachineType
    {
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
    public static class GetProjectsResponseVariant3ProjectResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectResourceConfigBuildMachineType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineType.Enhanced => "enhanced",
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineType.Standard => "standard",
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineType.Enhanced,
                "standard" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineType.Standard,
                "turbo" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}