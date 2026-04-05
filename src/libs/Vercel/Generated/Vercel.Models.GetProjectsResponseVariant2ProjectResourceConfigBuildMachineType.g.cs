
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectResourceConfigBuildMachineType
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
    public static class GetProjectsResponseVariant2ProjectResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectResourceConfigBuildMachineType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineType.Enhanced => "enhanced",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineType.Standard => "standard",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineType.Enhanced,
                "standard" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineType.Standard,
                "turbo" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}