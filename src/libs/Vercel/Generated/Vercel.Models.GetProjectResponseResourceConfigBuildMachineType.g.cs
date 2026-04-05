
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseResourceConfigBuildMachineType
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
    public static class GetProjectResponseResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseResourceConfigBuildMachineType value)
        {
            return value switch
            {
                GetProjectResponseResourceConfigBuildMachineType.Enhanced => "enhanced",
                GetProjectResponseResourceConfigBuildMachineType.Standard => "standard",
                GetProjectResponseResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetProjectResponseResourceConfigBuildMachineType.Enhanced,
                "standard" => GetProjectResponseResourceConfigBuildMachineType.Standard,
                "turbo" => GetProjectResponseResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}