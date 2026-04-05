
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType
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
    public static class GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType.Standard => "standard",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}